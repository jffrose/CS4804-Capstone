using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Net;
using System.Web.Script.Serialization;

namespace AzureAEDFinderWCFServiceWebRole
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    public class Service1 : AEDServiceInterface
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public List<AED> GetAllAEDs()
        {
            var context = new vtrescueEntities();
            return context.AEDs.ToList<AED>();
        }

        public List<AED> GetClosestAEDs(Coordinate coord)
        {
            var context = new vtrescueEntities();
            var buildings = context.buildings;
            var allAeds = context.AEDs;

            List<AED> aeds = new List<AED>();
            building closestBuilding = null;
            double dis = -1;
            foreach (building b in buildings)
            {
                double loc_dis = GetDistance(coord, b);
                if (dis < 0 || loc_dis < dis)
                {
                    List<AED> temp_aeds = new List<AED>();
                    foreach (AED a in allAeds)
                    {
                        if (a.building == b.name)
                        {
                            temp_aeds.Add(a);
                        }
                    }
                    if (temp_aeds.Count > 0)
                    {
                        dis = loc_dis;
                        closestBuilding = b;
                        aeds = temp_aeds;
                    }
                }
            }
            return aeds;

        }

        public building GetClosestBuilding(Coordinate coord)
        {
            var context = new vtrescueEntities();
            var buildings = context.buildings;

            building closestBuilding = null;
            double dis = -1;
            foreach( building b in buildings )
            {
                double loc_dis = GetDistance(coord, b);
                if (dis < 0 || loc_dis < dis)
                {
                    dis = loc_dis;
                    closestBuilding = b;
                } 
            }

            return closestBuilding;
        }


        public List<Coordinate> GetWalkingDirections(Coordinate coord)
        {
            string response = GetGoogleMapsDirections(coord, GetClosestBuilding(coord));
            var serializer = new JavaScriptSerializer();
            serializer.RegisterConverters(new[] { new DynamicJsonConverter() });

            dynamic obj = serializer.Deserialize(response, typeof(object));


            List<Coordinate> coords = new List<Coordinate>();
            Coordinate start = new Coordinate();
            start.Latitude = (double)obj.routes[0].legs[0].start_location.lat;
            start.Latitude = (double)obj.routes[0].legs[0].start_location.lng;

            var numSteps = obj.routes.legs.steps.Count;
            for (var i = 0; i < numSteps; i++)
            {
                Coordinate c = new Coordinate();
                c.Latitude = (double)obj.routes[0].legs[0].steps[i].end_location.lat;
                c.Longitude = (double)obj.routes[0].legs[0].steps[i].end_location.lng;
                coords.Add(c);
            }

            return coords;
            
        }

        private static string GetGoogleMapsDirections(Coordinate coord, building b)
        {
            string url = "http://maps.googleapis.com/maps/api/directions/json?origin="
                + coord.Latitude.ToString() + "," + coord.Longitude.ToString() + "&destination="
                + b.latitude.ToString() + "," + b.longitude.ToString() + "&mode=walking&sensor=false";

            string responseString = "";
            try
            {
                var request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "GET";
                

                var response = (HttpWebResponse)request.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream());
                return reader.ReadToEnd();
            }
            catch (Exception ex)
            {
                responseString += "ERROR: " + ex.Message;
                return responseString;
            }

        }
        private static double GetDistance(Coordinate coord, building build)
        {
            //pythagoras theorem c^2 = a^2 + b^2
            //thus c = square root(a^2 + b^2)
            double a = (double)(coord.Latitude - build.latitude);
            double b = (double)(coord.Longitude - build.longitude);

            return Math.Sqrt(a * a + b * b);
        }

    }
}
