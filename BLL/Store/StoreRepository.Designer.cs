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
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("StoreRepository", "FK_SectionDetails_Sections", "Section", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(BLL.Store.Section), "SectionDetail", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(BLL.Store.SectionDetail), true)]
[assembly: EdmRelationshipAttribute("StoreRepository", "FK_Sections_Sections", "Section", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(BLL.Store.Section), "Section1", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(BLL.Store.Section), true)]
[assembly: EdmRelationshipAttribute("StoreRepository", "FK_Sections_SectionTypes", "SectionType", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(BLL.Store.SectionType), "Section", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(BLL.Store.Section), true)]

#endregion

namespace BLL.Store
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class StoreRepositoryContainer : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new StoreRepositoryContainer object using the connection string found in the 'StoreRepositoryContainer' section of the application configuration file.
        /// </summary>
        public StoreRepositoryContainer() : base("name=StoreRepositoryContainer", "StoreRepositoryContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new StoreRepositoryContainer object.
        /// </summary>
        public StoreRepositoryContainer(string connectionString) : base(connectionString, "StoreRepositoryContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new StoreRepositoryContainer object.
        /// </summary>
        public StoreRepositoryContainer(EntityConnection connection) : base(connection, "StoreRepositoryContainer")
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
        public ObjectSet<SectionDetail> SectionDetails
        {
            get
            {
                if ((_SectionDetails == null))
                {
                    _SectionDetails = base.CreateObjectSet<SectionDetail>("SectionDetails");
                }
                return _SectionDetails;
            }
        }
        private ObjectSet<SectionDetail> _SectionDetails;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Section> Sections
        {
            get
            {
                if ((_Sections == null))
                {
                    _Sections = base.CreateObjectSet<Section>("Sections");
                }
                return _Sections;
            }
        }
        private ObjectSet<Section> _Sections;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<SectionType> SectionTypes
        {
            get
            {
                if ((_SectionTypes == null))
                {
                    _SectionTypes = base.CreateObjectSet<SectionType>("SectionTypes");
                }
                return _SectionTypes;
            }
        }
        private ObjectSet<SectionType> _SectionTypes;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the SectionDetails EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToSectionDetails(SectionDetail sectionDetail)
        {
            base.AddObject("SectionDetails", sectionDetail);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Sections EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToSections(Section section)
        {
            base.AddObject("Sections", section);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the SectionTypes EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToSectionTypes(SectionType sectionType)
        {
            base.AddObject("SectionTypes", sectionType);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="StoreRepository", Name="Section")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Section : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Section object.
        /// </summary>
        /// <param name="sectionID">Initial value of the SectionID property.</param>
        public static Section CreateSection(global::System.Int32 sectionID)
        {
            Section section = new Section();
            section.SectionID = sectionID;
            return section;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 SectionID
        {
            get
            {
                return _SectionID;
            }
            set
            {
                if (_SectionID != value)
                {
                    OnSectionIDChanging(value);
                    ReportPropertyChanging("SectionID");
                    _SectionID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("SectionID");
                    OnSectionIDChanged();
                }
            }
        }
        private global::System.Int32 _SectionID;
        partial void OnSectionIDChanging(global::System.Int32 value);
        partial void OnSectionIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> SectionIDP
        {
            get
            {
                return _SectionIDP;
            }
            set
            {
                OnSectionIDPChanging(value);
                ReportPropertyChanging("SectionIDP");
                _SectionIDP = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("SectionIDP");
                OnSectionIDPChanged();
            }
        }
        private Nullable<global::System.Int32> _SectionIDP;
        partial void OnSectionIDPChanging(Nullable<global::System.Int32> value);
        partial void OnSectionIDPChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Title
        {
            get
            {
                return _Title;
            }
            set
            {
                OnTitleChanging(value);
                ReportPropertyChanging("Title");
                _Title = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Title");
                OnTitleChanged();
            }
        }
        private global::System.String _Title;
        partial void OnTitleChanging(global::System.String value);
        partial void OnTitleChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String UrlNice
        {
            get
            {
                return _UrlNice;
            }
            set
            {
                OnUrlNiceChanging(value);
                ReportPropertyChanging("UrlNice");
                _UrlNice = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("UrlNice");
                OnUrlNiceChanged();
            }
        }
        private global::System.String _UrlNice;
        partial void OnUrlNiceChanging(global::System.String value);
        partial void OnUrlNiceChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> SectionTypeID
        {
            get
            {
                return _SectionTypeID;
            }
            set
            {
                OnSectionTypeIDChanging(value);
                ReportPropertyChanging("SectionTypeID");
                _SectionTypeID = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("SectionTypeID");
                OnSectionTypeIDChanged();
            }
        }
        private Nullable<global::System.Int32> _SectionTypeID;
        partial void OnSectionTypeIDChanging(Nullable<global::System.Int32> value);
        partial void OnSectionTypeIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> AddedData
        {
            get
            {
                return _AddedData;
            }
            set
            {
                OnAddedDataChanging(value);
                ReportPropertyChanging("AddedData");
                _AddedData = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("AddedData");
                OnAddedDataChanged();
            }
        }
        private Nullable<global::System.DateTime> _AddedData;
        partial void OnAddedDataChanging(Nullable<global::System.DateTime> value);
        partial void OnAddedDataChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String AddedBy
        {
            get
            {
                return _AddedBy;
            }
            set
            {
                OnAddedByChanging(value);
                ReportPropertyChanging("AddedBy");
                _AddedBy = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("AddedBy");
                OnAddedByChanged();
            }
        }
        private global::System.String _AddedBy;
        partial void OnAddedByChanging(global::System.String value);
        partial void OnAddedByChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> UpdateData
        {
            get
            {
                return _UpdateData;
            }
            set
            {
                OnUpdateDataChanging(value);
                ReportPropertyChanging("UpdateData");
                _UpdateData = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("UpdateData");
                OnUpdateDataChanged();
            }
        }
        private Nullable<global::System.DateTime> _UpdateData;
        partial void OnUpdateDataChanging(Nullable<global::System.DateTime> value);
        partial void OnUpdateDataChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String UpdateBy
        {
            get
            {
                return _UpdateBy;
            }
            set
            {
                OnUpdateByChanging(value);
                ReportPropertyChanging("UpdateBy");
                _UpdateBy = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("UpdateBy");
                OnUpdateByChanged();
            }
        }
        private global::System.String _UpdateBy;
        partial void OnUpdateByChanging(global::System.String value);
        partial void OnUpdateByChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Boolean> Active
        {
            get
            {
                return _Active;
            }
            set
            {
                OnActiveChanging(value);
                ReportPropertyChanging("Active");
                _Active = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Active");
                OnActiveChanged();
            }
        }
        private Nullable<global::System.Boolean> _Active;
        partial void OnActiveChanging(Nullable<global::System.Boolean> value);
        partial void OnActiveChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> Importance
        {
            get
            {
                return _Importance;
            }
            set
            {
                OnImportanceChanging(value);
                ReportPropertyChanging("Importance");
                _Importance = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Importance");
                OnImportanceChanged();
            }
        }
        private Nullable<global::System.Int32> _Importance;
        partial void OnImportanceChanging(Nullable<global::System.Int32> value);
        partial void OnImportanceChanged();
    
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

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("StoreRepository", "FK_SectionDetails_Sections", "SectionDetail")]
        public SectionDetail SectionDetail
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<SectionDetail>("StoreRepository.FK_SectionDetails_Sections", "SectionDetail").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<SectionDetail>("StoreRepository.FK_SectionDetails_Sections", "SectionDetail").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<SectionDetail> SectionDetailReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<SectionDetail>("StoreRepository.FK_SectionDetails_Sections", "SectionDetail");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<SectionDetail>("StoreRepository.FK_SectionDetails_Sections", "SectionDetail", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("StoreRepository", "FK_Sections_Sections", "Section1")]
        public EntityCollection<Section> Sections1
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Section>("StoreRepository.FK_Sections_Sections", "Section1");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Section>("StoreRepository.FK_Sections_Sections", "Section1", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("StoreRepository", "FK_Sections_Sections", "Section")]
        public Section Section1
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Section>("StoreRepository.FK_Sections_Sections", "Section").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Section>("StoreRepository.FK_Sections_Sections", "Section").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Section> Section1Reference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Section>("StoreRepository.FK_Sections_Sections", "Section");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Section>("StoreRepository.FK_Sections_Sections", "Section", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("StoreRepository", "FK_Sections_SectionTypes", "SectionType")]
        public SectionType SectionType
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<SectionType>("StoreRepository.FK_Sections_SectionTypes", "SectionType").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<SectionType>("StoreRepository.FK_Sections_SectionTypes", "SectionType").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<SectionType> SectionTypeReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<SectionType>("StoreRepository.FK_Sections_SectionTypes", "SectionType");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<SectionType>("StoreRepository.FK_Sections_SectionTypes", "SectionType", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="StoreRepository", Name="SectionDetail")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class SectionDetail : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new SectionDetail object.
        /// </summary>
        /// <param name="sectionID">Initial value of the SectionID property.</param>
        public static SectionDetail CreateSectionDetail(global::System.Int32 sectionID)
        {
            SectionDetail sectionDetail = new SectionDetail();
            sectionDetail.SectionID = sectionID;
            return sectionDetail;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 SectionID
        {
            get
            {
                return _SectionID;
            }
            set
            {
                if (_SectionID != value)
                {
                    OnSectionIDChanging(value);
                    ReportPropertyChanging("SectionID");
                    _SectionID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("SectionID");
                    OnSectionIDChanged();
                }
            }
        }
        private global::System.Int32 _SectionID;
        partial void OnSectionIDChanging(global::System.Int32 value);
        partial void OnSectionIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String PageDescription
        {
            get
            {
                return _PageDescription;
            }
            set
            {
                OnPageDescriptionChanging(value);
                ReportPropertyChanging("PageDescription");
                _PageDescription = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("PageDescription");
                OnPageDescriptionChanged();
            }
        }
        private global::System.String _PageDescription;
        partial void OnPageDescriptionChanging(global::System.String value);
        partial void OnPageDescriptionChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String PageTitle
        {
            get
            {
                return _PageTitle;
            }
            set
            {
                OnPageTitleChanging(value);
                ReportPropertyChanging("PageTitle");
                _PageTitle = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("PageTitle");
                OnPageTitleChanged();
            }
        }
        private global::System.String _PageTitle;
        partial void OnPageTitleChanging(global::System.String value);
        partial void OnPageTitleChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String PageKeywords
        {
            get
            {
                return _PageKeywords;
            }
            set
            {
                OnPageKeywordsChanging(value);
                ReportPropertyChanging("PageKeywords");
                _PageKeywords = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("PageKeywords");
                OnPageKeywordsChanged();
            }
        }
        private global::System.String _PageKeywords;
        partial void OnPageKeywordsChanging(global::System.String value);
        partial void OnPageKeywordsChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("StoreRepository", "FK_SectionDetails_Sections", "Section")]
        public Section Section
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Section>("StoreRepository.FK_SectionDetails_Sections", "Section").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Section>("StoreRepository.FK_SectionDetails_Sections", "Section").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Section> SectionReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Section>("StoreRepository.FK_SectionDetails_Sections", "Section");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Section>("StoreRepository.FK_SectionDetails_Sections", "Section", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="StoreRepository", Name="SectionType")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class SectionType : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new SectionType object.
        /// </summary>
        /// <param name="sectionTypeID">Initial value of the SectionTypeID property.</param>
        public static SectionType CreateSectionType(global::System.Int32 sectionTypeID)
        {
            SectionType sectionType = new SectionType();
            sectionType.SectionTypeID = sectionTypeID;
            return sectionType;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 SectionTypeID
        {
            get
            {
                return _SectionTypeID;
            }
            set
            {
                if (_SectionTypeID != value)
                {
                    OnSectionTypeIDChanging(value);
                    ReportPropertyChanging("SectionTypeID");
                    _SectionTypeID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("SectionTypeID");
                    OnSectionTypeIDChanged();
                }
            }
        }
        private global::System.Int32 _SectionTypeID;
        partial void OnSectionTypeIDChanging(global::System.Int32 value);
        partial void OnSectionTypeIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Title
        {
            get
            {
                return _Title;
            }
            set
            {
                OnTitleChanging(value);
                ReportPropertyChanging("Title");
                _Title = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Title");
                OnTitleChanged();
            }
        }
        private global::System.String _Title;
        partial void OnTitleChanging(global::System.String value);
        partial void OnTitleChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("StoreRepository", "FK_Sections_SectionTypes", "Section")]
        public EntityCollection<Section> Sections
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Section>("StoreRepository.FK_Sections_SectionTypes", "Section");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Section>("StoreRepository.FK_Sections_SectionTypes", "Section", value);
                }
            }
        }

        #endregion
    }

    #endregion
    
}