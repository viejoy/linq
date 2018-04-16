﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("csactivityModel", "tcourststudent", "tcours", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(BSCSActivity.tcours), "tstudent", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(BSCSActivity.tstudent))]

#endregion

namespace BSCSActivity
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class csactivityEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new csactivityEntities object using the connection string found in the 'csactivityEntities' section of the application configuration file.
        /// </summary>
        public csactivityEntities() : base("name=csactivityEntities", "csactivityEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new csactivityEntities object.
        /// </summary>
        public csactivityEntities(string connectionString) : base(connectionString, "csactivityEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new csactivityEntities object.
        /// </summary>
        public csactivityEntities(EntityConnection connection) : base(connection, "csactivityEntities")
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
        public ObjectSet<tcours> tcourses
        {
            get
            {
                if ((_tcourses == null))
                {
                    _tcourses = base.CreateObjectSet<tcours>("tcourses");
                }
                return _tcourses;
            }
        }
        private ObjectSet<tcours> _tcourses;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<tstudent> tstudents
        {
            get
            {
                if ((_tstudents == null))
                {
                    _tstudents = base.CreateObjectSet<tstudent>("tstudents");
                }
                return _tstudents;
            }
        }
        private ObjectSet<tstudent> _tstudents;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the tcourses EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotcourses(tcours tcours)
        {
            base.AddObject("tcourses", tcours);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the tstudents EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotstudents(tstudent tstudent)
        {
            base.AddObject("tstudents", tstudent);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="csactivityModel", Name="tcours")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class tcours : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new tcours object.
        /// </summary>
        /// <param name="cOURSE_ID">Initial value of the COURSE_ID property.</param>
        public static tcours Createtcours(global::System.Int32 cOURSE_ID)
        {
            tcours tcours = new tcours();
            tcours.COURSE_ID = cOURSE_ID;
            return tcours;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 COURSE_ID
        {
            get
            {
                return _COURSE_ID;
            }
            set
            {
                if (_COURSE_ID != value)
                {
                    OnCOURSE_IDChanging(value);
                    ReportPropertyChanging("COURSE_ID");
                    _COURSE_ID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("COURSE_ID");
                    OnCOURSE_IDChanged();
                }
            }
        }
        private global::System.Int32 _COURSE_ID;
        partial void OnCOURSE_IDChanging(global::System.Int32 value);
        partial void OnCOURSE_IDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String COURSE_NAME
        {
            get
            {
                return _COURSE_NAME;
            }
            set
            {
                OnCOURSE_NAMEChanging(value);
                ReportPropertyChanging("COURSE_NAME");
                _COURSE_NAME = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("COURSE_NAME");
                OnCOURSE_NAMEChanged();
            }
        }
        private global::System.String _COURSE_NAME;
        partial void OnCOURSE_NAMEChanging(global::System.String value);
        partial void OnCOURSE_NAMEChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("csactivityModel", "tcourststudent", "tstudent")]
        public EntityCollection<tstudent> tstudents
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<tstudent>("csactivityModel.tcourststudent", "tstudent");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<tstudent>("csactivityModel.tcourststudent", "tstudent", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="csactivityModel", Name="tstudent")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class tstudent : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new tstudent object.
        /// </summary>
        /// <param name="sTUDENT_ID">Initial value of the STUDENT_ID property.</param>
        public static tstudent Createtstudent(global::System.Int32 sTUDENT_ID)
        {
            tstudent tstudent = new tstudent();
            tstudent.STUDENT_ID = sTUDENT_ID;
            return tstudent;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 STUDENT_ID
        {
            get
            {
                return _STUDENT_ID;
            }
            set
            {
                if (_STUDENT_ID != value)
                {
                    OnSTUDENT_IDChanging(value);
                    ReportPropertyChanging("STUDENT_ID");
                    _STUDENT_ID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("STUDENT_ID");
                    OnSTUDENT_IDChanged();
                }
            }
        }
        private global::System.Int32 _STUDENT_ID;
        partial void OnSTUDENT_IDChanging(global::System.Int32 value);
        partial void OnSTUDENT_IDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String LAST_NAME
        {
            get
            {
                return _LAST_NAME;
            }
            set
            {
                OnLAST_NAMEChanging(value);
                ReportPropertyChanging("LAST_NAME");
                _LAST_NAME = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("LAST_NAME");
                OnLAST_NAMEChanged();
            }
        }
        private global::System.String _LAST_NAME;
        partial void OnLAST_NAMEChanging(global::System.String value);
        partial void OnLAST_NAMEChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String FIRST_NAME
        {
            get
            {
                return _FIRST_NAME;
            }
            set
            {
                OnFIRST_NAMEChanging(value);
                ReportPropertyChanging("FIRST_NAME");
                _FIRST_NAME = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("FIRST_NAME");
                OnFIRST_NAMEChanged();
            }
        }
        private global::System.String _FIRST_NAME;
        partial void OnFIRST_NAMEChanging(global::System.String value);
        partial void OnFIRST_NAMEChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String ADDRESS
        {
            get
            {
                return _ADDRESS;
            }
            set
            {
                OnADDRESSChanging(value);
                ReportPropertyChanging("ADDRESS");
                _ADDRESS = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("ADDRESS");
                OnADDRESSChanged();
            }
        }
        private global::System.String _ADDRESS;
        partial void OnADDRESSChanging(global::System.String value);
        partial void OnADDRESSChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("csactivityModel", "tcourststudent", "tcours")]
        public tcours tcour
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<tcours>("csactivityModel.tcourststudent", "tcours").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<tcours>("csactivityModel.tcourststudent", "tcours").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<tcours> tcourReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<tcours>("csactivityModel.tcourststudent", "tcours");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<tcours>("csactivityModel.tcourststudent", "tcours", value);
                }
            }
        }

        #endregion

    }

    #endregion

    
}