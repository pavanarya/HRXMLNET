// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.0.33213
//    <NameSpace>HRXML.Net</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>True</EnableDataBinding><EnableLazyLoading>False</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>True</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>True</IncludeSerializeMethod><UseBaseClass>True</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>True</GenerateCloneMethod><GenerateDataContracts>True</GenerateDataContracts><CodeBaseTag>Net35</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>True</GenerateXMLAttributes><EnableEncoding>False</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>False</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>ASCII</Encoder><CustomUsings></CustomUsings><ExcludeIncludedTypes>False</ExcludeIncludedTypes><EnableInitializeFields>True</EnableInitializeFields>
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
    using System.Text;
    using System.Collections.Generic;
    using System.Runtime.Serialization;


    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.450")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://ns.hr-xml.org/2007-04-15")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://ns.hr-xml.org/2007-04-15", IsNullable = true)]
    [System.Runtime.Serialization.DataContractAttribute(Name = "IndOrganizationalInfoType", Namespace = "http://ns.hr-xml.org/2007-04-15")]
    public partial class IndOrganizationalInfoType : EntityBase<IndOrganizationalInfoType>
    {

        private List<IndEmployeeOrganizationRefType> organizationField;

        private List<IndEmployeeOrganizationalUnitRefType> organizationalUnitField;

        private List<IndEmployeeWorkSiteRefType> workLocationField;

        private UserAreaType userAreaField;

        /// <summary>
        /// IndOrganizationalInfoType class constructor
        /// </summary>
        public IndOrganizationalInfoType()
        {
            this.userAreaField = new UserAreaType();
            this.workLocationField = new List<IndEmployeeWorkSiteRefType>();
            this.organizationalUnitField = new List<IndEmployeeOrganizationalUnitRefType>();
            this.organizationField = new List<IndEmployeeOrganizationRefType>();
        }

        [System.Xml.Serialization.XmlElementAttribute("Organization", Order = 0)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<IndEmployeeOrganizationRefType> Organization
        {
            get
            {
                return this.organizationField;
            }
            set
            {
                if ((this.organizationField != null))
                {
                    if ((organizationField.Equals(value) != true))
                    {
                        this.organizationField = value;
                        this.OnPropertyChanged("Organization");
                    }
                }
                else
                {
                    this.organizationField = value;
                    this.OnPropertyChanged("Organization");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("OrganizationalUnit", Order = 1)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<IndEmployeeOrganizationalUnitRefType> OrganizationalUnit
        {
            get
            {
                return this.organizationalUnitField;
            }
            set
            {
                if ((this.organizationalUnitField != null))
                {
                    if ((organizationalUnitField.Equals(value) != true))
                    {
                        this.organizationalUnitField = value;
                        this.OnPropertyChanged("OrganizationalUnit");
                    }
                }
                else
                {
                    this.organizationalUnitField = value;
                    this.OnPropertyChanged("OrganizationalUnit");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("WorkLocation", Order = 2)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<IndEmployeeWorkSiteRefType> WorkLocation
        {
            get
            {
                return this.workLocationField;
            }
            set
            {
                if ((this.workLocationField != null))
                {
                    if ((workLocationField.Equals(value) != true))
                    {
                        this.workLocationField = value;
                        this.OnPropertyChanged("WorkLocation");
                    }
                }
                else
                {
                    this.workLocationField = value;
                    this.OnPropertyChanged("WorkLocation");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public UserAreaType UserArea
        {
            get
            {
                return this.userAreaField;
            }
            set
            {
                if ((this.userAreaField != null))
                {
                    if ((userAreaField.Equals(value) != true))
                    {
                        this.userAreaField = value;
                        this.OnPropertyChanged("UserArea");
                    }
                }
                else
                {
                    this.userAreaField = value;
                    this.OnPropertyChanged("UserArea");
                }
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.450")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://ns.hr-xml.org/2007-04-15")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://ns.hr-xml.org/2007-04-15", IsNullable = true)]
    [System.Runtime.Serialization.DataContractAttribute(Name = "IndEmployeeOrganizationRefType", Namespace = "http://ns.hr-xml.org/2007-04-15")]
    public partial class IndEmployeeOrganizationRefType : IndOrganizationRefType, System.ComponentModel.INotifyPropertyChanged
    {

        private System.DateTime validFromField;

        private bool validFromFieldSpecified;

        private System.DateTime validToField;

        private bool validToFieldSpecified;

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime validFrom
        {
            get
            {
                return this.validFromField;
            }
            set
            {
                if ((validFromField.Equals(value) != true))
                {
                    this.validFromField = value;
                    this.OnPropertyChanged("validFrom");
                }
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool validFromSpecified
        {
            get
            {
                return this.validFromFieldSpecified;
            }
            set
            {
                if ((validFromFieldSpecified.Equals(value) != true))
                {
                    this.validFromFieldSpecified = value;
                    this.OnPropertyChanged("validFromSpecified");
                }
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime validTo
        {
            get
            {
                return this.validToField;
            }
            set
            {
                if ((validToField.Equals(value) != true))
                {
                    this.validToField = value;
                    this.OnPropertyChanged("validTo");
                }
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool validToSpecified
        {
            get
            {
                return this.validToFieldSpecified;
            }
            set
            {
                if ((validToFieldSpecified.Equals(value) != true))
                {
                    this.validToFieldSpecified = value;
                    this.OnPropertyChanged("validToSpecified");
                }
            }
        }
    }

    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IndEmployeeOrganizationRefType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.450")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://ns.hr-xml.org/2007-04-15")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://ns.hr-xml.org/2007-04-15", IsNullable = true)]
    [System.Runtime.Serialization.DataContractAttribute(Name = "IndOrganizationRefType", Namespace = "http://ns.hr-xml.org/2007-04-15")]
    public partial class IndOrganizationRefType : EntityBase<IndOrganizationRefType>
    {

        private string organizationNameField;

        private EntityIdType organizationIdField;

        private EntityIdType taxIdField;

        private EntityIdType legalIdField;

        /// <summary>
        /// IndOrganizationRefType class constructor
        /// </summary>
        public IndOrganizationRefType()
        {
            this.legalIdField = new EntityIdType();
            this.taxIdField = new EntityIdType();
            this.organizationIdField = new EntityIdType();
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string OrganizationName
        {
            get
            {
                return this.organizationNameField;
            }
            set
            {
                if ((this.organizationNameField != null))
                {
                    if ((organizationNameField.Equals(value) != true))
                    {
                        this.organizationNameField = value;
                        this.OnPropertyChanged("OrganizationName");
                    }
                }
                else
                {
                    this.organizationNameField = value;
                    this.OnPropertyChanged("OrganizationName");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public EntityIdType OrganizationId
        {
            get
            {
                return this.organizationIdField;
            }
            set
            {
                if ((this.organizationIdField != null))
                {
                    if ((organizationIdField.Equals(value) != true))
                    {
                        this.organizationIdField = value;
                        this.OnPropertyChanged("OrganizationId");
                    }
                }
                else
                {
                    this.organizationIdField = value;
                    this.OnPropertyChanged("OrganizationId");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public EntityIdType TaxId
        {
            get
            {
                return this.taxIdField;
            }
            set
            {
                if ((this.taxIdField != null))
                {
                    if ((taxIdField.Equals(value) != true))
                    {
                        this.taxIdField = value;
                        this.OnPropertyChanged("TaxId");
                    }
                }
                else
                {
                    this.taxIdField = value;
                    this.OnPropertyChanged("TaxId");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public EntityIdType LegalId
        {
            get
            {
                return this.legalIdField;
            }
            set
            {
                if ((this.legalIdField != null))
                {
                    if ((legalIdField.Equals(value) != true))
                    {
                        this.legalIdField = value;
                        this.OnPropertyChanged("LegalId");
                    }
                }
                else
                {
                    this.legalIdField = value;
                    this.OnPropertyChanged("LegalId");
                }
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.450")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://ns.hr-xml.org/2007-04-15")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://ns.hr-xml.org/2007-04-15", IsNullable = true)]
    [System.Runtime.Serialization.DataContractAttribute(Name = "IndEmployeeOrganizationalUnitRefType", Namespace = "http://ns.hr-xml.org/2007-04-15")]
    public partial class IndEmployeeOrganizationalUnitRefType : EntityBase<IndEmployeeOrganizationalUnitRefType>
    {

        private string organizationalUnitNameField;

        private EntityIdType organizationalUnitIdField;

        private OrgAccountingCodeType accountingCodeField;

        private System.DateTime validFromField;

        private bool validFromFieldSpecified;

        private System.DateTime validToField;

        private bool validToFieldSpecified;

        /// <summary>
        /// IndEmployeeOrganizationalUnitRefType class constructor
        /// </summary>
        public IndEmployeeOrganizationalUnitRefType()
        {
            this.accountingCodeField = new OrgAccountingCodeType();
            this.organizationalUnitIdField = new EntityIdType();
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string OrganizationalUnitName
        {
            get
            {
                return this.organizationalUnitNameField;
            }
            set
            {
                if ((this.organizationalUnitNameField != null))
                {
                    if ((organizationalUnitNameField.Equals(value) != true))
                    {
                        this.organizationalUnitNameField = value;
                        this.OnPropertyChanged("OrganizationalUnitName");
                    }
                }
                else
                {
                    this.organizationalUnitNameField = value;
                    this.OnPropertyChanged("OrganizationalUnitName");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public EntityIdType OrganizationalUnitId
        {
            get
            {
                return this.organizationalUnitIdField;
            }
            set
            {
                if ((this.organizationalUnitIdField != null))
                {
                    if ((organizationalUnitIdField.Equals(value) != true))
                    {
                        this.organizationalUnitIdField = value;
                        this.OnPropertyChanged("OrganizationalUnitId");
                    }
                }
                else
                {
                    this.organizationalUnitIdField = value;
                    this.OnPropertyChanged("OrganizationalUnitId");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public OrgAccountingCodeType AccountingCode
        {
            get
            {
                return this.accountingCodeField;
            }
            set
            {
                if ((this.accountingCodeField != null))
                {
                    if ((accountingCodeField.Equals(value) != true))
                    {
                        this.accountingCodeField = value;
                        this.OnPropertyChanged("AccountingCode");
                    }
                }
                else
                {
                    this.accountingCodeField = value;
                    this.OnPropertyChanged("AccountingCode");
                }
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime validFrom
        {
            get
            {
                return this.validFromField;
            }
            set
            {
                if ((validFromField.Equals(value) != true))
                {
                    this.validFromField = value;
                    this.OnPropertyChanged("validFrom");
                }
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool validFromSpecified
        {
            get
            {
                return this.validFromFieldSpecified;
            }
            set
            {
                if ((validFromFieldSpecified.Equals(value) != true))
                {
                    this.validFromFieldSpecified = value;
                    this.OnPropertyChanged("validFromSpecified");
                }
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime validTo
        {
            get
            {
                return this.validToField;
            }
            set
            {
                if ((validToField.Equals(value) != true))
                {
                    this.validToField = value;
                    this.OnPropertyChanged("validTo");
                }
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool validToSpecified
        {
            get
            {
                return this.validToFieldSpecified;
            }
            set
            {
                if ((validToFieldSpecified.Equals(value) != true))
                {
                    this.validToFieldSpecified = value;
                    this.OnPropertyChanged("validToSpecified");
                }
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.450")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://ns.hr-xml.org/2007-04-15")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://ns.hr-xml.org/2007-04-15", IsNullable = true)]
    [System.Runtime.Serialization.DataContractAttribute(Name = "OrgAccountingCodeType", Namespace = "http://ns.hr-xml.org/2007-04-15")]
    public partial class OrgAccountingCodeType : EntityBase<OrgAccountingCodeType>
    {

        private string descriptionField;

        private System.DateTime validFromField;

        private bool validFromFieldSpecified;

        private System.DateTime validToField;

        private bool validToFieldSpecified;

        private string valueField;

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string description
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
                        this.OnPropertyChanged("description");
                    }
                }
                else
                {
                    this.descriptionField = value;
                    this.OnPropertyChanged("description");
                }
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime validFrom
        {
            get
            {
                return this.validFromField;
            }
            set
            {
                if ((validFromField.Equals(value) != true))
                {
                    this.validFromField = value;
                    this.OnPropertyChanged("validFrom");
                }
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool validFromSpecified
        {
            get
            {
                return this.validFromFieldSpecified;
            }
            set
            {
                if ((validFromFieldSpecified.Equals(value) != true))
                {
                    this.validFromFieldSpecified = value;
                    this.OnPropertyChanged("validFromSpecified");
                }
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime validTo
        {
            get
            {
                return this.validToField;
            }
            set
            {
                if ((validToField.Equals(value) != true))
                {
                    this.validToField = value;
                    this.OnPropertyChanged("validTo");
                }
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool validToSpecified
        {
            get
            {
                return this.validToFieldSpecified;
            }
            set
            {
                if ((validToFieldSpecified.Equals(value) != true))
                {
                    this.validToFieldSpecified = value;
                    this.OnPropertyChanged("validToSpecified");
                }
            }
        }

        [System.Xml.Serialization.XmlTextAttribute()]
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
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.450")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://ns.hr-xml.org/2007-04-15")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://ns.hr-xml.org/2007-04-15", IsNullable = true)]
    [System.Runtime.Serialization.DataContractAttribute(Name = "IndEmployeeWorkSiteRefType", Namespace = "http://ns.hr-xml.org/2007-04-15")]
    public partial class IndEmployeeWorkSiteRefType : EntityBase<IndEmployeeWorkSiteRefType>
    {

        private string nameField;

        private EntityIdType idField;

        private PostalAddressType postalAddressField;

        private System.DateTime validFromField;

        private bool validFromFieldSpecified;

        private System.DateTime validToField;

        private bool validToFieldSpecified;

        private decimal allocationPercentageField;

        private bool allocationPercentageFieldSpecified;

        /// <summary>
        /// IndEmployeeWorkSiteRefType class constructor
        /// </summary>
        public IndEmployeeWorkSiteRefType()
        {
            this.postalAddressField = new PostalAddressType();
            this.idField = new EntityIdType();
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
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

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
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

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
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

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime validFrom
        {
            get
            {
                return this.validFromField;
            }
            set
            {
                if ((validFromField.Equals(value) != true))
                {
                    this.validFromField = value;
                    this.OnPropertyChanged("validFrom");
                }
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool validFromSpecified
        {
            get
            {
                return this.validFromFieldSpecified;
            }
            set
            {
                if ((validFromFieldSpecified.Equals(value) != true))
                {
                    this.validFromFieldSpecified = value;
                    this.OnPropertyChanged("validFromSpecified");
                }
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime validTo
        {
            get
            {
                return this.validToField;
            }
            set
            {
                if ((validToField.Equals(value) != true))
                {
                    this.validToField = value;
                    this.OnPropertyChanged("validTo");
                }
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool validToSpecified
        {
            get
            {
                return this.validToFieldSpecified;
            }
            set
            {
                if ((validToFieldSpecified.Equals(value) != true))
                {
                    this.validToFieldSpecified = value;
                    this.OnPropertyChanged("validToSpecified");
                }
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal allocationPercentage
        {
            get
            {
                return this.allocationPercentageField;
            }
            set
            {
                if ((allocationPercentageField.Equals(value) != true))
                {
                    this.allocationPercentageField = value;
                    this.OnPropertyChanged("allocationPercentage");
                }
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool allocationPercentageSpecified
        {
            get
            {
                return this.allocationPercentageFieldSpecified;
            }
            set
            {
                if ((allocationPercentageFieldSpecified.Equals(value) != true))
                {
                    this.allocationPercentageFieldSpecified = value;
                    this.OnPropertyChanged("allocationPercentageSpecified");
                }
            }
        }
    }
}
