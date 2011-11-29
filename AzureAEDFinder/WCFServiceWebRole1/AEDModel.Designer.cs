﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]

namespace AzureAEDFinderWCFServiceWebRole
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class vtrescueEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new vtrescueEntities object using the connection string found in the 'vtrescueEntities' section of the application configuration file.
        /// </summary>
        public vtrescueEntities() : base("name=vtrescueEntities", "vtrescueEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new vtrescueEntities object.
        /// </summary>
        public vtrescueEntities(string connectionString) : base(connectionString, "vtrescueEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new vtrescueEntities object.
        /// </summary>
        public vtrescueEntities(EntityConnection connection) : base(connection, "vtrescueEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<AED> AEDs
        {
            get
            {
                if ((_AEDs == null))
                {
                    _AEDs = base.CreateObjectSet<AED>("AEDs");
                }
                return _AEDs;
            }
        }
        private ObjectSet<AED> _AEDs;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<building> buildings
        {
            get
            {
                if ((_buildings == null))
                {
                    _buildings = base.CreateObjectSet<building>("buildings");
                }
                return _buildings;
            }
        }
        private ObjectSet<building> _buildings;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the AEDs EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToAEDs(AED aED)
        {
            base.AddObject("AEDs", aED);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the buildings EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTobuildings(building building)
        {
            base.AddObject("buildings", building);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="vtrescueModel", Name="AED")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class AED : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new AED object.
        /// </summary>
        /// <param name="id">Initial value of the ID property.</param>
        /// <param name="pad_expiration">Initial value of the pad_expiration property.</param>
        public static AED CreateAED(global::System.Int32 id, global::System.DateTime pad_expiration)
        {
            AED aED = new AED();
            aED.ID = id;
            aED.pad_expiration = pad_expiration;
            return aED;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ID
        {
            get
            {
                return _ID;
            }
            set
            {
                if (_ID != value)
                {
                    OnIDChanging(value);
                    ReportPropertyChanging("ID");
                    _ID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ID");
                    OnIDChanged();
                }
            }
        }
        private global::System.Int32 _ID;
        partial void OnIDChanging(global::System.Int32 value);
        partial void OnIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String SN
        {
            get
            {
                return _SN;
            }
            set
            {
                OnSNChanging(value);
                ReportPropertyChanging("SN");
                _SN = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("SN");
                OnSNChanged();
            }
        }
        private global::System.String _SN;
        partial void OnSNChanging(global::System.String value);
        partial void OnSNChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String department
        {
            get
            {
                return _department;
            }
            set
            {
                OndepartmentChanging(value);
                ReportPropertyChanging("department");
                _department = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("department");
                OndepartmentChanged();
            }
        }
        private global::System.String _department;
        partial void OndepartmentChanging(global::System.String value);
        partial void OndepartmentChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String building
        {
            get
            {
                return _building;
            }
            set
            {
                OnbuildingChanging(value);
                ReportPropertyChanging("building");
                _building = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("building");
                OnbuildingChanged();
            }
        }
        private global::System.String _building;
        partial void OnbuildingChanging(global::System.String value);
        partial void OnbuildingChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime pad_expiration
        {
            get
            {
                return _pad_expiration;
            }
            set
            {
                Onpad_expirationChanging(value);
                ReportPropertyChanging("pad_expiration");
                _pad_expiration = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("pad_expiration");
                Onpad_expirationChanged();
            }
        }
        private global::System.DateTime _pad_expiration;
        partial void Onpad_expirationChanging(global::System.DateTime value);
        partial void Onpad_expirationChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String loc_description
        {
            get
            {
                return _loc_description;
            }
            set
            {
                Onloc_descriptionChanging(value);
                ReportPropertyChanging("loc_description");
                _loc_description = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("loc_description");
                Onloc_descriptionChanged();
            }
        }
        private global::System.String _loc_description;
        partial void Onloc_descriptionChanging(global::System.String value);
        partial void Onloc_descriptionChanged();

        #endregion
    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="vtrescueModel", Name="building")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class building : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new building object.
        /// </summary>
        /// <param name="id">Initial value of the ID property.</param>
        /// <param name="latitude">Initial value of the latitude property.</param>
        /// <param name="longitude">Initial value of the longitude property.</param>
        /// <param name="name">Initial value of the name property.</param>
        public static building Createbuilding(global::System.Int32 id, global::System.Double latitude, global::System.Double longitude, global::System.String name)
        {
            building building = new building();
            building.ID = id;
            building.latitude = latitude;
            building.longitude = longitude;
            building.name = name;
            return building;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ID
        {
            get
            {
                return _ID;
            }
            set
            {
                if (_ID != value)
                {
                    OnIDChanging(value);
                    ReportPropertyChanging("ID");
                    _ID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ID");
                    OnIDChanged();
                }
            }
        }
        private global::System.Int32 _ID;
        partial void OnIDChanging(global::System.Int32 value);
        partial void OnIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Double latitude
        {
            get
            {
                return _latitude;
            }
            set
            {
                OnlatitudeChanging(value);
                ReportPropertyChanging("latitude");
                _latitude = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("latitude");
                OnlatitudeChanged();
            }
        }
        private global::System.Double _latitude;
        partial void OnlatitudeChanging(global::System.Double value);
        partial void OnlatitudeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Double longitude
        {
            get
            {
                return _longitude;
            }
            set
            {
                OnlongitudeChanging(value);
                ReportPropertyChanging("longitude");
                _longitude = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("longitude");
                OnlongitudeChanged();
            }
        }
        private global::System.Double _longitude;
        partial void OnlongitudeChanging(global::System.Double value);
        partial void OnlongitudeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String name
        {
            get
            {
                return _name;
            }
            set
            {
                OnnameChanging(value);
                ReportPropertyChanging("name");
                _name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("name");
                OnnameChanged();
            }
        }
        private global::System.String _name;
        partial void OnnameChanging(global::System.String value);
        partial void OnnameChanged();

        #endregion
    
    }

    #endregion
    
}
