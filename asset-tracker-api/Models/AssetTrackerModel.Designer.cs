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
using AssetTracker.DTO;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("AssetTrackerModel", "fk_facility_address", "address", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(asset_tracker_api.Models.address), "facility", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(asset_tracker_api.Models.facility), true)]
[assembly: EdmRelationshipAttribute("AssetTrackerModel", "fk_asset_facility", "facility", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(asset_tracker_api.Models.facility), "asset", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(asset_tracker_api.Models.asset), true)]
[assembly: EdmRelationshipAttribute("AssetTrackerModel", "fk_asset_room", "room", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(asset_tracker_api.Models.room), "asset", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(asset_tracker_api.Models.asset), true)]
[assembly: EdmRelationshipAttribute("AssetTrackerModel", "fk_room_facility", "facility", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(asset_tracker_api.Models.facility), "room", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(asset_tracker_api.Models.room), true)]

#endregion

namespace asset_tracker_api.Models
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class RBSAssetTrackerEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new RBSAssetTrackerEntities object using the connection string found in the 'RBSAssetTrackerEntities' section of the application configuration file.
        /// </summary>
        public RBSAssetTrackerEntities() : base("name=RBSAssetTrackerEntities", "RBSAssetTrackerEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new RBSAssetTrackerEntities object.
        /// </summary>
        public RBSAssetTrackerEntities(string connectionString) : base(connectionString, "RBSAssetTrackerEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new RBSAssetTrackerEntities object.
        /// </summary>
        public RBSAssetTrackerEntities(EntityConnection connection) : base(connection, "RBSAssetTrackerEntities")
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
        public ObjectSet<address> addresses
        {
            get
            {
                if ((_addresses == null))
                {
                    _addresses = base.CreateObjectSet<address>("addresses");
                }
                return _addresses;
            }
        }
        private ObjectSet<address> _addresses;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<asset> assets
        {
            get
            {
                if ((_assets == null))
                {
                    _assets = base.CreateObjectSet<asset>("assets");
                }
                return _assets;
            }
        }
        private ObjectSet<asset> _assets;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<facility> facilities
        {
            get
            {
                if ((_facilities == null))
                {
                    _facilities = base.CreateObjectSet<facility>("facilities");
                }
                return _facilities;
            }
        }
        private ObjectSet<facility> _facilities;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<room> rooms
        {
            get
            {
                if ((_rooms == null))
                {
                    _rooms = base.CreateObjectSet<room>("rooms");
                }
                return _rooms;
            }
        }
        private ObjectSet<room> _rooms;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the addresses EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToaddresses(address address)
        {
            base.AddObject("addresses", address);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the assets EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToassets(asset asset)
        {
            base.AddObject("assets", asset);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the facilities EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTofacilities(facility facility)
        {
            base.AddObject("facilities", facility);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the rooms EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTorooms(room room)
        {
            base.AddObject("rooms", room);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="AssetTrackerModel", Name="address")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class address : EntityObject
    {
        public addressDTO toDTO()
        {
            return new addressDTO()
            {
                id = this.id,
                line_1 = this.line_1,
                line_2 = this.line_2,
                city = this.city,
                state = this.state,
                zip = this.zip,
            };
        }

        #region Factory Method
    
        /// <summary>
        /// Create a new address object.
        /// </summary>
        /// <param name="id">Initial value of the id property.</param>
        /// <param name="line_1">Initial value of the line_1 property.</param>
        /// <param name="city">Initial value of the city property.</param>
        /// <param name="state">Initial value of the state property.</param>
        /// <param name="zip">Initial value of the zip property.</param>
        public static address Createaddress(global::System.Int32 id, global::System.String line_1, global::System.String city, global::System.String state, global::System.String zip)
        {
            address address = new address();
            address.id = id;
            address.line_1 = line_1;
            address.city = city;
            address.state = state;
            address.zip = zip;
            return address;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 id
        {
            get
            {
                return _id;
            }
            set
            {
                if (_id != value)
                {
                    OnidChanging(value);
                    ReportPropertyChanging("id");
                    _id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("id");
                    OnidChanged();
                }
            }
        }
        private global::System.Int32 _id;
        partial void OnidChanging(global::System.Int32 value);
        partial void OnidChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String line_1
        {
            get
            {
                return _line_1;
            }
            set
            {
                Online_1Changing(value);
                ReportPropertyChanging("line_1");
                _line_1 = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("line_1");
                Online_1Changed();
            }
        }
        private global::System.String _line_1;
        partial void Online_1Changing(global::System.String value);
        partial void Online_1Changed();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String line_2
        {
            get
            {
                return _line_2;
            }
            set
            {
                Online_2Changing(value);
                ReportPropertyChanging("line_2");
                _line_2 = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("line_2");
                Online_2Changed();
            }
        }
        private global::System.String _line_2;
        partial void Online_2Changing(global::System.String value);
        partial void Online_2Changed();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String city
        {
            get
            {
                return _city;
            }
            set
            {
                OncityChanging(value);
                ReportPropertyChanging("city");
                _city = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("city");
                OncityChanged();
            }
        }
        private global::System.String _city;
        partial void OncityChanging(global::System.String value);
        partial void OncityChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String state
        {
            get
            {
                return _state;
            }
            set
            {
                OnstateChanging(value);
                ReportPropertyChanging("state");
                _state = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("state");
                OnstateChanged();
            }
        }
        private global::System.String _state;
        partial void OnstateChanging(global::System.String value);
        partial void OnstateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String zip
        {
            get
            {
                return _zip;
            }
            set
            {
                OnzipChanging(value);
                ReportPropertyChanging("zip");
                _zip = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("zip");
                OnzipChanged();
            }
        }
        private global::System.String _zip;
        partial void OnzipChanging(global::System.String value);
        partial void OnzipChanged();

        #endregion
    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="AssetTrackerModel", Name="asset")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class asset : EntityObject
    {
        public assetDTO toDTO()
        {
            return new assetDTO()
            {
                id = this.id,
                facility_id = this.facility_id,
                room_id = this.room_id,
                name = this.name,
                sku = this.sku,
                description = this.description,
                add_date = this.add_date.ToString("d"),
                last_scan = this.last_scan.ToString("d"),
            };
        }


        #region Factory Method
    
        /// <summary>
        /// Create a new asset object.
        /// </summary>
        /// <param name="id">Initial value of the id property.</param>
        /// <param name="facility_id">Initial value of the facility_id property.</param>
        /// <param name="room_id">Initial value of the room_id property.</param>
        /// <param name="name">Initial value of the name property.</param>
        /// <param name="add_date">Initial value of the add_date property.</param>
        /// <param name="last_scan">Initial value of the last_scan property.</param>
        public static asset Createasset(global::System.Int32 id, global::System.Int32 facility_id, global::System.Int32 room_id, global::System.String name, global::System.DateTime add_date, global::System.DateTime last_scan)
        {
            asset asset = new asset();
            asset.id = id;
            asset.facility_id = facility_id;
            asset.room_id = room_id;
            asset.name = name;
            asset.add_date = add_date;
            asset.last_scan = last_scan;
            return asset;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 id
        {
            get
            {
                return _id;
            }
            set
            {
                if (_id != value)
                {
                    OnidChanging(value);
                    ReportPropertyChanging("id");
                    _id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("id");
                    OnidChanged();
                }
            }
        }
        private global::System.Int32 _id;
        partial void OnidChanging(global::System.Int32 value);
        partial void OnidChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 facility_id
        {
            get
            {
                return _facility_id;
            }
            set
            {
                Onfacility_idChanging(value);
                ReportPropertyChanging("facility_id");
                _facility_id = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("facility_id");
                Onfacility_idChanged();
            }
        }
        private global::System.Int32 _facility_id;
        partial void Onfacility_idChanging(global::System.Int32 value);
        partial void Onfacility_idChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 room_id
        {
            get
            {
                return _room_id;
            }
            set
            {
                Onroom_idChanging(value);
                ReportPropertyChanging("room_id");
                _room_id = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("room_id");
                Onroom_idChanged();
            }
        }
        private global::System.Int32 _room_id;
        partial void Onroom_idChanging(global::System.Int32 value);
        partial void Onroom_idChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String sku
        {
            get
            {
                return _sku;
            }
            set
            {
                OnskuChanging(value);
                ReportPropertyChanging("sku");
                _sku = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("sku");
                OnskuChanged();
            }
        }
        private global::System.String _sku;
        partial void OnskuChanging(global::System.String value);
        partial void OnskuChanged();
    
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
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String description
        {
            get
            {
                return _description;
            }
            set
            {
                OndescriptionChanging(value);
                ReportPropertyChanging("description");
                _description = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("description");
                OndescriptionChanged();
            }
        }
        private global::System.String _description;
        partial void OndescriptionChanging(global::System.String value);
        partial void OndescriptionChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime add_date
        {
            get
            {
                return _add_date;
            }
            set
            {
                Onadd_dateChanging(value);
                ReportPropertyChanging("add_date");
                _add_date = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("add_date");
                Onadd_dateChanged();
            }
        }
        private global::System.DateTime _add_date;
        partial void Onadd_dateChanging(global::System.DateTime value);
        partial void Onadd_dateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime last_scan
        {
            get
            {
                return _last_scan;
            }
            set
            {
                Onlast_scanChanging(value);
                ReportPropertyChanging("last_scan");
                _last_scan = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("last_scan");
                Onlast_scanChanged();
            }
        }
        private global::System.DateTime _last_scan;
        partial void Onlast_scanChanging(global::System.DateTime value);
        partial void Onlast_scanChanged();

        #endregion
    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="AssetTrackerModel", Name="facility")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class facility : EntityObject
    {
        public facilityDTO toDTO()
        {
            return new facilityDTO()
            {
                id = this.id,
                name = this.name,
                add_date = this.add_date,
            };
        }

        #region Factory Method
    
        /// <summary>
        /// Create a new facility object.
        /// </summary>
        /// <param name="id">Initial value of the id property.</param>
        /// <param name="user_id">Initial value of the user_id property.</param>
        /// <param name="address_id">Initial value of the address_id property.</param>
        /// <param name="name">Initial value of the name property.</param>
        /// <param name="add_date">Initial value of the add_date property.</param>
        public static facility Createfacility(global::System.Int32 id, global::System.Guid user_id, global::System.Int32 address_id, global::System.String name, global::System.DateTime add_date)
        {
            facility facility = new facility();
            facility.id = id;
            facility.user_id = user_id;
            facility.address_id = address_id;
            facility.name = name;
            facility.add_date = add_date;
            return facility;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 id
        {
            get
            {
                return _id;
            }
            set
            {
                if (_id != value)
                {
                    OnidChanging(value);
                    ReportPropertyChanging("id");
                    _id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("id");
                    OnidChanged();
                }
            }
        }
        private global::System.Int32 _id;
        partial void OnidChanging(global::System.Int32 value);
        partial void OnidChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Guid user_id
        {
            get
            {
                return _user_id;
            }
            set
            {
                Onuser_idChanging(value);
                ReportPropertyChanging("user_id");
                _user_id = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("user_id");
                Onuser_idChanged();
            }
        }
        private global::System.Guid _user_id;
        partial void Onuser_idChanging(global::System.Guid value);
        partial void Onuser_idChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 address_id
        {
            get
            {
                return _address_id;
            }
            set
            {
                Onaddress_idChanging(value);
                ReportPropertyChanging("address_id");
                _address_id = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("address_id");
                Onaddress_idChanged();
            }
        }
        private global::System.Int32 _address_id;
        partial void Onaddress_idChanging(global::System.Int32 value);
        partial void Onaddress_idChanged();
    
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
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime add_date
        {
            get
            {
                return _add_date;
            }
            set
            {
                Onadd_dateChanging(value);
                ReportPropertyChanging("add_date");
                _add_date = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("add_date");
                Onadd_dateChanged();
            }
        }
        private global::System.DateTime _add_date;
        partial void Onadd_dateChanging(global::System.DateTime value);
        partial void Onadd_dateChanged();

        #endregion
    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="AssetTrackerModel", Name="room")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class room : EntityObject
    {
        public roomDTO toDTO()
        {
            return new roomDTO() 
            { 
                id = this.id,
                facility_id = this.facility_id,
                name = this.name,
                add_date = this.add_date,
            };
        }

        #region Factory Method
    
        /// <summary>
        /// Create a new room object.
        /// </summary>
        /// <param name="id">Initial value of the id property.</param>
        /// <param name="facility_id">Initial value of the facility_id property.</param>
        /// <param name="name">Initial value of the name property.</param>
        /// <param name="add_date">Initial value of the add_date property.</param>
        public static room Createroom(global::System.Int32 id, global::System.Int32 facility_id, global::System.String name, global::System.DateTime add_date)
        {
            room room = new room();
            room.id = id;
            room.facility_id = facility_id;
            room.name = name;
            room.add_date = add_date;
            return room;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 id
        {
            get
            {
                return _id;
            }
            set
            {
                if (_id != value)
                {
                    OnidChanging(value);
                    ReportPropertyChanging("id");
                    _id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("id");
                    OnidChanged();
                }
            }
        }
        private global::System.Int32 _id;
        partial void OnidChanging(global::System.Int32 value);
        partial void OnidChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 facility_id
        {
            get
            {
                return _facility_id;
            }
            set
            {
                Onfacility_idChanging(value);
                ReportPropertyChanging("facility_id");
                _facility_id = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("facility_id");
                Onfacility_idChanged();
            }
        }
        private global::System.Int32 _facility_id;
        partial void Onfacility_idChanging(global::System.Int32 value);
        partial void Onfacility_idChanged();
    
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
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime add_date
        {
            get
            {
                return _add_date;
            }
            set
            {
                Onadd_dateChanging(value);
                ReportPropertyChanging("add_date");
                _add_date = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("add_date");
                Onadd_dateChanged();
            }
        }
        private global::System.DateTime _add_date;
        partial void Onadd_dateChanging(global::System.DateTime value);
        partial void Onadd_dateChanged();

        #endregion
    
    }

    #endregion
    
}
