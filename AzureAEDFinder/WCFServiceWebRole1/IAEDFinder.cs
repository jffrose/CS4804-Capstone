using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace AzureAEDFinderWCFServiceWebRole
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface AEDServiceInterface
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        [OperationContract]
        List<AED> GetAllAEDs();

        [OperationContract]
        building GetClosestBuilding(Coordinate coord);

        [OperationContract]
        List<Coordinate> GetWalkingDirections(Coordinate coord);

        [OperationContract]
        List<AED> GetClosestAEDs(Coordinate coord);
    }

    [DataContract]
    public class Coordinate
    {
        double longitude, latitude;
        [DataMember]
        public double Longitude
        {
            get { return longitude; }
            set { longitude = value; }
        }
        [DataMember]
        public double Latitude
        {
            get { return latitude; }
            set { latitude = value; }
        }
    
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
