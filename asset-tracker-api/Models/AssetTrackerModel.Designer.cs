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

[assembly: EdmRelationshipAttribute("AssetTrackerModel", "fk_asset_facility", "facility", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(asset_tracker_api.Models.facility), "asset", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(asset_tracker_api.Models.asset), true)]
[assembly: EdmRelationshipAttribute("AssetTrackerModel", "fk_asset_room", "room", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(asset_tracker_api.Models.room), "asset", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(asset_tracker_api.Models.asset), true)]
[assembly: EdmRelationshipAttribute("AssetTrackerModel", "fk_room_facility", "facility", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(asset_tracker_api.Models.facility), "room", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(asset_tracker_api.Models.room), true)]
[assembly: EdmRelationshipAttribute("AssetTrackerModel", "FK_facility_user", "aspnet_Users", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(asset_tracker_api.Models.aspnet_User), "facility", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(asset_tracker_api.Models.facility), true)]

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
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<aspnet_User> aspnet_Users
        {
            get
            {
                if ((_aspnet_Users == null))
                {
                    _aspnet_Users = base.CreateObjectSet<aspnet_User>("aspnet_Users");
                }
                return _aspnet_Users;
            }
        }
        private ObjectSet<aspnet_User> _aspnet_Users;

        #endregion
        #region AddTo Methods
    
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
    
        /// <summary>
        /// Deprecated Method for adding a new object to the aspnet_Users EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToaspnet_Users(aspnet_User aspnet_Users)
        {
            base.AddObject("aspnet_Users", aspnet_Users);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="AssetTrackerModel", Name="aspnet_Users")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class aspnet_User : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new aspnet_Users object.
        /// </summary>
        /// <param name="applicationId">Initial value of the ApplicationId property.</param>
        /// <param name="userId">Initial value of the UserId property.</param>
        /// <param name="userName">Initial value of the UserName property.</param>
        /// <param name="loweredUserName">Initial value of the LoweredUserName property.</param>
        /// <param name="isAnonymous">Initial value of the IsAnonymous property.</param>
        /// <param name="lastActivityDate">Initial value of the LastActivityDate property.</param>
        public static aspnet_User Createaspnet_Users(global::System.Guid applicationId, global::System.Guid userId, global::System.String userName, global::System.String loweredUserName, global::System.Boolean isAnonymous, global::System.DateTime lastActivityDate)
        {
            aspnet_User aspnet_Users = new aspnet_User();
            aspnet_Users.ApplicationId = applicationId;
            aspnet_Users.UserId = userId;
            aspnet_Users.UserName = userName;
            aspnet_Users.LoweredUserName = loweredUserName;
            aspnet_Users.IsAnonymous = isAnonymous;
            aspnet_Users.LastActivityDate = lastActivityDate;
            return aspnet_Users;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Guid ApplicationId
        {
            get
            {
                return _ApplicationId;
            }
            set
            {
                OnApplicationIdChanging(value);
                ReportPropertyChanging("ApplicationId");
                _ApplicationId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("ApplicationId");
                OnApplicationIdChanged();
            }
        }
        private global::System.Guid _ApplicationId;
        partial void OnApplicationIdChanging(global::System.Guid value);
        partial void OnApplicationIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Guid UserId
        {
            get
            {
                return _UserId;
            }
            set
            {
                if (_UserId != value)
                {
                    OnUserIdChanging(value);
                    ReportPropertyChanging("UserId");
                    _UserId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("UserId");
                    OnUserIdChanged();
                }
            }
        }
        private global::System.Guid _UserId;
        partial void OnUserIdChanging(global::System.Guid value);
        partial void OnUserIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String UserName
        {
            get
            {
                return _UserName;
            }
            set
            {
                OnUserNameChanging(value);
                ReportPropertyChanging("UserName");
                _UserName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("UserName");
                OnUserNameChanged();
            }
        }
        private global::System.String _UserName;
        partial void OnUserNameChanging(global::System.String value);
        partial void OnUserNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String LoweredUserName
        {
            get
            {
                return _LoweredUserName;
            }
            set
            {
                OnLoweredUserNameChanging(value);
                ReportPropertyChanging("LoweredUserName");
                _LoweredUserName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("LoweredUserName");
                OnLoweredUserNameChanged();
            }
        }
        private global::System.String _LoweredUserName;
        partial void OnLoweredUserNameChanging(global::System.String value);
        partial void OnLoweredUserNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String MobileAlias
        {
            get
            {
                return _MobileAlias;
            }
            set
            {
                OnMobileAliasChanging(value);
                ReportPropertyChanging("MobileAlias");
                _MobileAlias = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("MobileAlias");
                OnMobileAliasChanged();
            }
        }
        private global::System.String _MobileAlias;
        partial void OnMobileAliasChanging(global::System.String value);
        partial void OnMobileAliasChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Boolean IsAnonymous
        {
            get
            {
                return _IsAnonymous;
            }
            set
            {
                OnIsAnonymousChanging(value);
                ReportPropertyChanging("IsAnonymous");
                _IsAnonymous = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("IsAnonymous");
                OnIsAnonymousChanged();
            }
        }
        private global::System.Boolean _IsAnonymous;
        partial void OnIsAnonymousChanging(global::System.Boolean value);
        partial void OnIsAnonymousChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime LastActivityDate
        {
            get
            {
                return _LastActivityDate;
            }
            set
            {
                OnLastActivityDateChanging(value);
                ReportPropertyChanging("LastActivityDate");
                _LastActivityDate = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("LastActivityDate");
                OnLastActivityDateChanged();
            }
        }
        private global::System.DateTime _LastActivityDate;
        partial void OnLastActivityDateChanging(global::System.DateTime value);
        partial void OnLastActivityDateChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("AssetTrackerModel", "FK_facility_user", "facility")]
        public EntityCollection<facility> facilities
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<facility>("AssetTrackerModel.FK_facility_user", "facility");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<facility>("AssetTrackerModel.FK_facility_user", "facility", value);
                }
            }
        }

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
                line_1 = this.line_1,
                line_2 = this.line_2,
                city = this.city_,
                state = this.state,
                zip = this.zip,
            };
        }

        #region Factory Method
    
        /// <summary>
        /// Create a new facility object.
        /// </summary>
        /// <param name="id">Initial value of the id property.</param>
        /// <param name="user_id">Initial value of the user_id property.</param>
        /// <param name="name">Initial value of the name property.</param>
        /// <param name="add_date">Initial value of the add_date property.</param>
        public static facility Createfacility(global::System.Int32 id, global::System.Guid user_id, global::System.String name, global::System.DateTime add_date)
        {
            facility facility = new facility();
            facility.id = id;
            facility.user_id = user_id;
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
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
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
                _line_1 = StructuralObject.SetValidValue(value, true);
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
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
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
                _state = StructuralObject.SetValidValue(value, true);
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
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
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
                _zip = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("zip");
                OnzipChanged();
            }
        }
        private global::System.String _zip;
        partial void OnzipChanging(global::System.String value);
        partial void OnzipChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String city_
        {
            get
            {
                return _city_;
            }
            set
            {
                Oncity_Changing(value);
                ReportPropertyChanging("city_");
                _city_ = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("city_");
                Oncity_Changed();
            }
        }
        private global::System.String _city_;
        partial void Oncity_Changing(global::System.String value);
        partial void Oncity_Changed();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("AssetTrackerModel", "FK_facility_user", "aspnet_Users")]
        public aspnet_User aspnet_Users
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<aspnet_User>("AssetTrackerModel.FK_facility_user", "aspnet_Users").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<aspnet_User>("AssetTrackerModel.FK_facility_user", "aspnet_Users").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<aspnet_User> aspnet_UsersReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<aspnet_User>("AssetTrackerModel.FK_facility_user", "aspnet_Users");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<aspnet_User>("AssetTrackerModel.FK_facility_user", "aspnet_Users", value);
                }
            }
        }

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
