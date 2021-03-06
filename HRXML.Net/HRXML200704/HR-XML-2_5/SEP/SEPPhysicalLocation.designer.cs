// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.3.0.36516
//    <NameSpace>HRXML.Net</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>True</EnableDataBinding><EnableLasyLoading>False</EnableLasyLoading><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>True</EnableSummaryComment><IncludeSerializeMethod>True</IncludeSerializeMethod><UseBaseClass>True</UseBaseClass><GenerateCloneMethod>True</GenerateCloneMethod><GenerateDataContracts>True</GenerateDataContracts><CodeBaseTag>Net35</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>True</GenerateXMLAttributes><AutomaticProperties>False</AutomaticProperties><DisableDebug>False</DisableDebug><CustomUsings></CustomUsings><ExcludeIncludedTypes>True</ExcludeIncludedTypes><EnableInitializeFields>True</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------
namespace HRXML.Net
{
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;
    using System.IO;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://ns.hr-xml.org/2007-04-15")]
    [System.Xml.Serialization.XmlRootAttribute("PhysicalLocation", Namespace = "http://ns.hr-xml.org/2007-04-15", IsNullable = false)]
    [System.Runtime.Serialization.DataContractAttribute(Name = "PhysicalLocationType", Namespace = "http://ns.hr-xml.org/2007-04-15")]
    public partial class PhysicalLocationType : EntityBase<PhysicalLocationType>
    {

        private EntityIdType idField;

        private string nameField;

        private PhysicalLocationTypeEffectiveDate effectiveDateField;

        private SpatialLocationType spatialLocationField;

        private List<string> travelDirectionsField;

        private PostalAddressType postalAddressField;

        private List<LocationAreaType> areaField;

        private string commentsField;

        /// <summary>
        /// PhysicalLocationType class constructor
        /// </summary>
        public PhysicalLocationType()
        {
            this.postalAddressField = new PostalAddressType();
            this.idField = new EntityIdType();
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public EntityIdType Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                if ((this.idField != null))
                {
                    if ((idField.Equals(value) != true))
                    {
                        this.idField = value;
                        this.OnPropertyChanged("Id");
                    }
                }
                else
                {
                    this.idField = value;
                    this.OnPropertyChanged("Id");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                if ((this.nameField != null))
                {
                    if ((nameField.Equals(value) != true))
                    {
                        this.nameField = value;
                        this.OnPropertyChanged("Name");
                    }
                }
                else
                {
                    this.nameField = value;
                    this.OnPropertyChanged("Name");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public PhysicalLocationTypeEffectiveDate EffectiveDate
        {
            get
            {
                return this.effectiveDateField;
            }
            set
            {
                if ((this.effectiveDateField != null))
                {
                    if ((effectiveDateField.Equals(value) != true))
                    {
                        this.effectiveDateField = value;
                        this.OnPropertyChanged("EffectiveDate");
                    }
                }
                else
                {
                    this.effectiveDateField = value;
                    this.OnPropertyChanged("EffectiveDate");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public SpatialLocationType SpatialLocation
        {
            get
            {
                return this.spatialLocationField;
            }
            set
            {
                if ((this.spatialLocationField != null))
                {
                    if ((spatialLocationField.Equals(value) != true))
                    {
                        this.spatialLocationField = value;
                        this.OnPropertyChanged("SpatialLocation");
                    }
                }
                else
                {
                    this.spatialLocationField = value;
                    this.OnPropertyChanged("SpatialLocation");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("TravelDirections")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<string> TravelDirections
        {
            get
            {
                return this.travelDirectionsField;
            }
            set
            {
                if ((this.travelDirectionsField != null))
                {
                    if ((travelDirectionsField.Equals(value) != true))
                    {
                        this.travelDirectionsField = value;
                        this.OnPropertyChanged("TravelDirections");
                    }
                }
                else
                {
                    this.travelDirectionsField = value;
                    this.OnPropertyChanged("TravelDirections");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public PostalAddressType PostalAddress
        {
            get
            {
                return this.postalAddressField;
            }
            set
            {
                if ((this.postalAddressField != null))
                {
                    if ((postalAddressField.Equals(value) != true))
                    {
                        this.postalAddressField = value;
                        this.OnPropertyChanged("PostalAddress");
                    }
                }
                else
                {
                    this.postalAddressField = value;
                    this.OnPropertyChanged("PostalAddress");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("Area")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<LocationAreaType> Area
        {
            get
            {
                return this.areaField;
            }
            set
            {
                if ((this.areaField != null))
                {
                    if ((areaField.Equals(value) != true))
                    {
                        this.areaField = value;
                        this.OnPropertyChanged("Area");
                    }
                }
                else
                {
                    this.areaField = value;
                    this.OnPropertyChanged("Area");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Comments
        {
            get
            {
                return this.commentsField;
            }
            set
            {
                if ((this.commentsField != null))
                {
                    if ((commentsField.Equals(value) != true))
                    {
                        this.commentsField = value;
                        this.OnPropertyChanged("Comments");
                    }
                }
                else
                {
                    this.commentsField = value;
                    this.OnPropertyChanged("Comments");
                }
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://ns.hr-xml.org/2007-04-15")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "PhysicalLocationTypeEffectiveDate", Namespace = "http://ns.hr-xml.org/2007-04-15")]
    public partial class PhysicalLocationTypeEffectiveDate : EntityBase<PhysicalLocationTypeEffectiveDate>
    {

        private string startDateField;

        private string endDateField;

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StartDate
        {
            get
            {
                return this.startDateField;
            }
            set
            {
                if ((this.startDateField != null))
                {
                    if ((startDateField.Equals(value) != true))
                    {
                        this.startDateField = value;
                        this.OnPropertyChanged("StartDate");
                    }
                }
                else
                {
                    this.startDateField = value;
                    this.OnPropertyChanged("StartDate");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EndDate
        {
            get
            {
                return this.endDateField;
            }
            set
            {
                if ((this.endDateField != null))
                {
                    if ((endDateField.Equals(value) != true))
                    {
                        this.endDateField = value;
                        this.OnPropertyChanged("EndDate");
                    }
                }
                else
                {
                    this.endDateField = value;
                    this.OnPropertyChanged("EndDate");
                }
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://ns.hr-xml.org/2007-04-15")]
    [System.Xml.Serialization.XmlRootAttribute("SpatialLocation", Namespace = "http://ns.hr-xml.org/2007-04-15", IsNullable = false)]
    [System.Runtime.Serialization.DataContractAttribute(Name = "SpatialLocationType", Namespace = "http://ns.hr-xml.org/2007-04-15")]
    public partial class SpatialLocationType : EntityBase<SpatialLocationType>
    {

        private decimal latitudeField;

        private decimal longitudeField;

        private decimal itemField;

        private AltitudeChoiceType itemElementNameField;

        private decimal horizontalAccuracyField;

        private bool horizontalAccuracyFieldSpecified;

        private decimal verticalAccuracyField;

        private bool verticalAccuracyFieldSpecified;

        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Latitude
        {
            get
            {
                return this.latitudeField;
            }
            set
            {
                if ((latitudeField.Equals(value) != true))
                {
                    this.latitudeField = value;
                    this.OnPropertyChanged("Latitude");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Longitude
        {
            get
            {
                return this.longitudeField;
            }
            set
            {
                if ((longitudeField.Equals(value) != true))
                {
                    this.longitudeField = value;
                    this.OnPropertyChanged("Longitude");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("Altitude", typeof(decimal))]
        [System.Xml.Serialization.XmlElementAttribute("AltitudeMeanSeaLevel", typeof(decimal))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                if ((itemField.Equals(value) != true))
                {
                    this.itemField = value;
                    this.OnPropertyChanged("Item");
                }
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public AltitudeChoiceType ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                if ((itemElementNameField.Equals(value) != true))
                {
                    this.itemElementNameField = value;
                    this.OnPropertyChanged("ItemElementName");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal HorizontalAccuracy
        {
            get
            {
                return this.horizontalAccuracyField;
            }
            set
            {
                if ((horizontalAccuracyField.Equals(value) != true))
                {
                    this.horizontalAccuracyField = value;
                    this.OnPropertyChanged("HorizontalAccuracy");
                }
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool HorizontalAccuracySpecified
        {
            get
            {
                return this.horizontalAccuracyFieldSpecified;
            }
            set
            {
                if ((horizontalAccuracyFieldSpecified.Equals(value) != true))
                {
                    this.horizontalAccuracyFieldSpecified = value;
                    this.OnPropertyChanged("HorizontalAccuracySpecified");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal VerticalAccuracy
        {
            get
            {
                return this.verticalAccuracyField;
            }
            set
            {
                if ((verticalAccuracyField.Equals(value) != true))
                {
                    this.verticalAccuracyField = value;
                    this.OnPropertyChanged("VerticalAccuracy");
                }
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool VerticalAccuracySpecified
        {
            get
            {
                return this.verticalAccuracyFieldSpecified;
            }
            set
            {
                if ((verticalAccuracyFieldSpecified.Equals(value) != true))
                {
                    this.verticalAccuracyFieldSpecified = value;
                    this.OnPropertyChanged("VerticalAccuracySpecified");
                }
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://ns.hr-xml.org/2007-04-15", IncludeInSchema = false)]
    public enum AltitudeChoiceType
    {

        /// <remarks/>
        Altitude,

        /// <remarks/>
        AltitudeMeanSeaLevel,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://ns.hr-xml.org/2007-04-15")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "LocationAreaType", Namespace = "http://ns.hr-xml.org/2007-04-15")]
    public partial class LocationAreaType : EntityBase<LocationAreaType>
    {

        private string descriptionField;

        private List<LocationAreaType> areaField;

        private string typeField;

        /// <summary>
        /// LocationAreaType class constructor
        /// </summary>
        public LocationAreaType()
        {
            this.areaField = new List<LocationAreaType>();
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                if ((this.descriptionField != null))
                {
                    if ((descriptionField.Equals(value) != true))
                    {
                        this.descriptionField = value;
                        this.OnPropertyChanged("Description");
                    }
                }
                else
                {
                    this.descriptionField = value;
                    this.OnPropertyChanged("Description");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("Area")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<LocationAreaType> Area
        {
            get
            {
                return this.areaField;
            }
            set
            {
                if ((this.areaField != null))
                {
                    if ((areaField.Equals(value) != true))
                    {
                        this.areaField = value;
                        this.OnPropertyChanged("Area");
                    }
                }
                else
                {
                    this.areaField = value;
                    this.OnPropertyChanged("Area");
                }
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                if ((this.typeField != null))
                {
                    if ((typeField.Equals(value) != true))
                    {
                        this.typeField = value;
                        this.OnPropertyChanged("type");
                    }
                }
                else
                {
                    this.typeField = value;
                    this.OnPropertyChanged("type");
                }
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://ns.hr-xml.org/2007-04-15")]
    [System.Xml.Serialization.XmlRootAttribute("SEPPhysicalLocation", Namespace = "http://ns.hr-xml.org/2007-04-15", IsNullable = false)]
    [System.Runtime.Serialization.DataContractAttribute(Name = "SEPPhysicalLocationType", Namespace = "http://ns.hr-xml.org/2007-04-15")]
    public partial class SEPPhysicalLocationType : EntityBase<SEPPhysicalLocationType>
    {

        private EntityIdType idField;

        private string nameField;

        private SEPPhysicalLocationTypeSpatialLocation spatialLocationField;

        private List<string> travelDirectionsField;

        private List<AreaType> areaField;

        private PostalAddressType postalAddressField;

        private string commentsField;

        /// <summary>
        /// SEPPhysicalLocationType class constructor
        /// </summary>
        public SEPPhysicalLocationType()
        {
            this.postalAddressField = new PostalAddressType();
            this.idField = new EntityIdType();
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public EntityIdType Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                if ((this.idField != null))
                {
                    if ((idField.Equals(value) != true))
                    {
                        this.idField = value;
                        this.OnPropertyChanged("Id");
                    }
                }
                else
                {
                    this.idField = value;
                    this.OnPropertyChanged("Id");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                if ((this.nameField != null))
                {
                    if ((nameField.Equals(value) != true))
                    {
                        this.nameField = value;
                        this.OnPropertyChanged("Name");
                    }
                }
                else
                {
                    this.nameField = value;
                    this.OnPropertyChanged("Name");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public SEPPhysicalLocationTypeSpatialLocation SpatialLocation
        {
            get
            {
                return this.spatialLocationField;
            }
            set
            {
                if ((this.spatialLocationField != null))
                {
                    if ((spatialLocationField.Equals(value) != true))
                    {
                        this.spatialLocationField = value;
                        this.OnPropertyChanged("SpatialLocation");
                    }
                }
                else
                {
                    this.spatialLocationField = value;
                    this.OnPropertyChanged("SpatialLocation");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("TravelDirections")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<string> TravelDirections
        {
            get
            {
                return this.travelDirectionsField;
            }
            set
            {
                if ((this.travelDirectionsField != null))
                {
                    if ((travelDirectionsField.Equals(value) != true))
                    {
                        this.travelDirectionsField = value;
                        this.OnPropertyChanged("TravelDirections");
                    }
                }
                else
                {
                    this.travelDirectionsField = value;
                    this.OnPropertyChanged("TravelDirections");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("Area")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<AreaType> Area
        {
            get
            {
                return this.areaField;
            }
            set
            {
                if ((this.areaField != null))
                {
                    if ((areaField.Equals(value) != true))
                    {
                        this.areaField = value;
                        this.OnPropertyChanged("Area");
                    }
                }
                else
                {
                    this.areaField = value;
                    this.OnPropertyChanged("Area");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public PostalAddressType PostalAddress
        {
            get
            {
                return this.postalAddressField;
            }
            set
            {
                if ((this.postalAddressField != null))
                {
                    if ((postalAddressField.Equals(value) != true))
                    {
                        this.postalAddressField = value;
                        this.OnPropertyChanged("PostalAddress");
                    }
                }
                else
                {
                    this.postalAddressField = value;
                    this.OnPropertyChanged("PostalAddress");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Comments
        {
            get
            {
                return this.commentsField;
            }
            set
            {
                if ((this.commentsField != null))
                {
                    if ((commentsField.Equals(value) != true))
                    {
                        this.commentsField = value;
                        this.OnPropertyChanged("Comments");
                    }
                }
                else
                {
                    this.commentsField = value;
                    this.OnPropertyChanged("Comments");
                }
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://ns.hr-xml.org/2007-04-15")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "SEPPhysicalLocationTypeSpatialLocation", Namespace = "http://ns.hr-xml.org/2007-04-15")]
    public partial class SEPPhysicalLocationTypeSpatialLocation : EntityBase<SEPPhysicalLocationTypeSpatialLocation>
    {

        private string latitudeField;

        private string longitudeField;

        private decimal itemField;

        private SEPPhysicalLocationAltitudeType itemElementNameField;

        private decimal horizontalAccuracyField;

        private bool horizontalAccuracyFieldSpecified;

        private decimal verticalAccuracyField;

        private bool verticalAccuracyFieldSpecified;

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Latitude
        {
            get
            {
                return this.latitudeField;
            }
            set
            {
                if ((this.latitudeField != null))
                {
                    if ((latitudeField.Equals(value) != true))
                    {
                        this.latitudeField = value;
                        this.OnPropertyChanged("Latitude");
                    }
                }
                else
                {
                    this.latitudeField = value;
                    this.OnPropertyChanged("Latitude");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Longitude
        {
            get
            {
                return this.longitudeField;
            }
            set
            {
                if ((this.longitudeField != null))
                {
                    if ((longitudeField.Equals(value) != true))
                    {
                        this.longitudeField = value;
                        this.OnPropertyChanged("Longitude");
                    }
                }
                else
                {
                    this.longitudeField = value;
                    this.OnPropertyChanged("Longitude");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("Altitude", typeof(decimal))]
        [System.Xml.Serialization.XmlElementAttribute("AltitudeMeanSeaLevel", typeof(decimal))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                if ((itemField.Equals(value) != true))
                {
                    this.itemField = value;
                    this.OnPropertyChanged("Item");
                }
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SEPPhysicalLocationAltitudeType ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                if ((itemElementNameField.Equals(value) != true))
                {
                    this.itemElementNameField = value;
                    this.OnPropertyChanged("ItemElementName");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal HorizontalAccuracy
        {
            get
            {
                return this.horizontalAccuracyField;
            }
            set
            {
                if ((horizontalAccuracyField.Equals(value) != true))
                {
                    this.horizontalAccuracyField = value;
                    this.OnPropertyChanged("HorizontalAccuracy");
                }
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool HorizontalAccuracySpecified
        {
            get
            {
                return this.horizontalAccuracyFieldSpecified;
            }
            set
            {
                if ((horizontalAccuracyFieldSpecified.Equals(value) != true))
                {
                    this.horizontalAccuracyFieldSpecified = value;
                    this.OnPropertyChanged("HorizontalAccuracySpecified");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal VerticalAccuracy
        {
            get
            {
                return this.verticalAccuracyField;
            }
            set
            {
                if ((verticalAccuracyField.Equals(value) != true))
                {
                    this.verticalAccuracyField = value;
                    this.OnPropertyChanged("VerticalAccuracy");
                }
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool VerticalAccuracySpecified
        {
            get
            {
                return this.verticalAccuracyFieldSpecified;
            }
            set
            {
                if ((verticalAccuracyFieldSpecified.Equals(value) != true))
                {
                    this.verticalAccuracyFieldSpecified = value;
                    this.OnPropertyChanged("VerticalAccuracySpecified");
                }
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://ns.hr-xml.org/2007-04-15", IncludeInSchema = false)]
    public enum SEPPhysicalLocationAltitudeType
    {

        /// <remarks/>
        Altitude,

        /// <remarks/>
        AltitudeMeanSeaLevel,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://ns.hr-xml.org/2007-04-15")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://ns.hr-xml.org/2007-04-15", IsNullable = true)]
    [System.Runtime.Serialization.DataContractAttribute(Name = "AreaType", Namespace = "http://ns.hr-xml.org/2007-04-15")]
    public partial class AreaType : EntityBase<AreaType>
    {

        private string valueField;

        private List<AreaType> areaField;

        private string typeField;

        /// <summary>
        /// AreaType class constructor
        /// </summary>
        public AreaType()
        {
            this.areaField = new List<AreaType>();
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                if ((this.valueField != null))
                {
                    if ((valueField.Equals(value) != true))
                    {
                        this.valueField = value;
                        this.OnPropertyChanged("Value");
                    }
                }
                else
                {
                    this.valueField = value;
                    this.OnPropertyChanged("Value");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("Area")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<AreaType> Area
        {
            get
            {
                return this.areaField;
            }
            set
            {
                if ((this.areaField != null))
                {
                    if ((areaField.Equals(value) != true))
                    {
                        this.areaField = value;
                        this.OnPropertyChanged("Area");
                    }
                }
                else
                {
                    this.areaField = value;
                    this.OnPropertyChanged("Area");
                }
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                if ((this.typeField != null))
                {
                    if ((typeField.Equals(value) != true))
                    {
                        this.typeField = value;
                        this.OnPropertyChanged("type");
                    }
                }
                else
                {
                    this.typeField = value;
                    this.OnPropertyChanged("type");
                }
            }
        }
    }
}
