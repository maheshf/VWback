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

namespace HRMS.DAL
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class PMSDbEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new PMSDbEntities object using the connection string found in the 'PMSDbEntities' section of the application configuration file.
        /// </summary>
        public PMSDbEntities() : base("name=PMSDbEntities", "PMSDbEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new PMSDbEntities object.
        /// </summary>
        public PMSDbEntities(string connectionString) : base(connectionString, "PMSDbEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new PMSDbEntities object.
        /// </summary>
        public PMSDbEntities(EntityConnection connection) : base(connection, "PMSDbEntities")
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
        public ObjectSet<CalendarList> CalendarLists
        {
            get
            {
                if ((_CalendarLists == null))
                {
                    _CalendarLists = base.CreateObjectSet<CalendarList>("CalendarLists");
                }
                return _CalendarLists;
            }
        }
        private ObjectSet<CalendarList> _CalendarLists;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<ShiftMaster> ShiftMasters
        {
            get
            {
                if ((_ShiftMasters == null))
                {
                    _ShiftMasters = base.CreateObjectSet<ShiftMaster>("ShiftMasters");
                }
                return _ShiftMasters;
            }
        }
        private ObjectSet<ShiftMaster> _ShiftMasters;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the CalendarLists EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToCalendarLists(CalendarList calendarList)
        {
            base.AddObject("CalendarLists", calendarList);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the ShiftMasters EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToShiftMasters(ShiftMaster shiftMaster)
        {
            base.AddObject("ShiftMasters", shiftMaster);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="Orbitphase2Model", Name="CalendarList")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class CalendarList : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new CalendarList object.
        /// </summary>
        /// <param name="calendarId">Initial value of the CalendarId property.</param>
        public static CalendarList CreateCalendarList(global::System.Int32 calendarId)
        {
            CalendarList calendarList = new CalendarList();
            calendarList.CalendarId = calendarId;
            return calendarList;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 CalendarId
        {
            get
            {
                return _CalendarId;
            }
            set
            {
                if (_CalendarId != value)
                {
                    OnCalendarIdChanging(value);
                    ReportPropertyChanging("CalendarId");
                    _CalendarId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("CalendarId");
                    OnCalendarIdChanged();
                }
            }
        }
        private global::System.Int32 _CalendarId;
        partial void OnCalendarIdChanging(global::System.Int32 value);
        partial void OnCalendarIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String CalendarLocation
        {
            get
            {
                return _CalendarLocation;
            }
            set
            {
                OnCalendarLocationChanging(value);
                ReportPropertyChanging("CalendarLocation");
                _CalendarLocation = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("CalendarLocation");
                OnCalendarLocationChanged();
            }
        }
        private global::System.String _CalendarLocation;
        partial void OnCalendarLocationChanging(global::System.String value);
        partial void OnCalendarLocationChanged();

        #endregion
    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="Orbitphase2Model", Name="ShiftMaster")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class ShiftMaster : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new ShiftMaster object.
        /// </summary>
        /// <param name="shiftID">Initial value of the ShiftID property.</param>
        /// <param name="shiftName">Initial value of the ShiftName property.</param>
        public static ShiftMaster CreateShiftMaster(global::System.Int32 shiftID, global::System.String shiftName)
        {
            ShiftMaster shiftMaster = new ShiftMaster();
            shiftMaster.ShiftID = shiftID;
            shiftMaster.ShiftName = shiftName;
            return shiftMaster;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ShiftID
        {
            get
            {
                return _ShiftID;
            }
            set
            {
                if (_ShiftID != value)
                {
                    OnShiftIDChanging(value);
                    ReportPropertyChanging("ShiftID");
                    _ShiftID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ShiftID");
                    OnShiftIDChanged();
                }
            }
        }
        private global::System.Int32 _ShiftID;
        partial void OnShiftIDChanging(global::System.Int32 value);
        partial void OnShiftIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String ShiftName
        {
            get
            {
                return _ShiftName;
            }
            set
            {
                OnShiftNameChanging(value);
                ReportPropertyChanging("ShiftName");
                _ShiftName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("ShiftName");
                OnShiftNameChanged();
            }
        }
        private global::System.String _ShiftName;
        partial void OnShiftNameChanging(global::System.String value);
        partial void OnShiftNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Description
        {
            get
            {
                return _Description;
            }
            set
            {
                OnDescriptionChanging(value);
                ReportPropertyChanging("Description");
                _Description = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Description");
                OnDescriptionChanged();
            }
        }
        private global::System.String _Description;
        partial void OnDescriptionChanging(global::System.String value);
        partial void OnDescriptionChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> ShiftInTime
        {
            get
            {
                return _ShiftInTime;
            }
            set
            {
                OnShiftInTimeChanging(value);
                ReportPropertyChanging("ShiftInTime");
                _ShiftInTime = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("ShiftInTime");
                OnShiftInTimeChanged();
            }
        }
        private Nullable<global::System.DateTime> _ShiftInTime;
        partial void OnShiftInTimeChanging(Nullable<global::System.DateTime> value);
        partial void OnShiftInTimeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> ShiftOutTime
        {
            get
            {
                return _ShiftOutTime;
            }
            set
            {
                OnShiftOutTimeChanging(value);
                ReportPropertyChanging("ShiftOutTime");
                _ShiftOutTime = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("ShiftOutTime");
                OnShiftOutTimeChanged();
            }
        }
        private Nullable<global::System.DateTime> _ShiftOutTime;
        partial void OnShiftOutTimeChanging(Nullable<global::System.DateTime> value);
        partial void OnShiftOutTimeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Boolean> ISActive
        {
            get
            {
                return _ISActive;
            }
            set
            {
                OnISActiveChanging(value);
                ReportPropertyChanging("ISActive");
                _ISActive = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("ISActive");
                OnISActiveChanged();
            }
        }
        private Nullable<global::System.Boolean> _ISActive;
        partial void OnISActiveChanging(Nullable<global::System.Boolean> value);
        partial void OnISActiveChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> ModifiedDate
        {
            get
            {
                return _ModifiedDate;
            }
            set
            {
                OnModifiedDateChanging(value);
                ReportPropertyChanging("ModifiedDate");
                _ModifiedDate = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("ModifiedDate");
                OnModifiedDateChanged();
            }
        }
        private Nullable<global::System.DateTime> _ModifiedDate;
        partial void OnModifiedDateChanging(Nullable<global::System.DateTime> value);
        partial void OnModifiedDateChanged();

        #endregion
    
    }

    #endregion
    
}
