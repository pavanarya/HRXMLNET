// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.0.38967
//    <NameSpace>HRXML.Net</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>True</EnableDataBinding><EnableLazyLoading>False</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>True</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>True</IncludeSerializeMethod><UseBaseClass>True</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>True</GenerateCloneMethod><GenerateDataContracts>True</GenerateDataContracts><CodeBaseTag>Net35</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>True</GenerateXMLAttributes><EnableEncoding>False</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>False</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>ASCII</Encoder><CustomUsings></CustomUsings><ExcludeIncludedTypes>True</ExcludeIncludedTypes><EnableInitializeFields>True</EnableInitializeFields>
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


    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.nocore.nl/2010-10")]
    [System.Xml.Serialization.XmlRootAttribute("NocoreHumanResource", Namespace = "http://www.nocore.nl/2010-10", IsNullable = false)]
    [System.Runtime.Serialization.DataContractAttribute(Name = "NocoreHumanResourceType", Namespace = "http://www.nocore.nl/2010-10")]
    public partial class NocoreHumanResourceType : EntityBase<NocoreHumanResourceType>
    {

        private string accountManagerField;

        private string socialSecurityNumberField;

        private string initialsField;

        private BankAccountInfoType bankAccountInfoField;

        private NationalityType nationalityField;

        private NocoreLocationType locationField;

        private string paymentPeriodField;

        private string placeOfBirthField;

        private string countryOfBirthCodeField;

        private string statusField;

        private List<FasePeriodType> faseHistorieField;

        private string maritalStatusField;

        private bool taxReductionField;

        private bool taxReductionFieldSpecified;

        private System.DateTime contractEndDateField;

        private bool contractEndDateFieldSpecified;

        private float contractHoursPerWeekField;

        private bool contractHoursPerWeekFieldSpecified;

        private System.DateTime modifiedField;

        /// <summary>
        /// NocoreHumanResourceType class constructor
        /// </summary>
        public NocoreHumanResourceType()
        {
            this.faseHistorieField = new List<FasePeriodType>();
            this.locationField = new NocoreLocationType();
            this.nationalityField = new NationalityType();
            this.bankAccountInfoField = new BankAccountInfoType();
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AccountManager
        {
            get
            {
                return this.accountManagerField;
            }
            set
            {
                if ((this.accountManagerField != null))
                {
                    if ((accountManagerField.Equals(value) != true))
                    {
                        this.accountManagerField = value;
                        this.OnPropertyChanged("AccountManager");
                    }
                }
                else
                {
                    this.accountManagerField = value;
                    this.OnPropertyChanged("AccountManager");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SocialSecurityNumber
        {
            get
            {
                return this.socialSecurityNumberField;
            }
            set
            {
                if ((this.socialSecurityNumberField != null))
                {
                    if ((socialSecurityNumberField.Equals(value) != true))
                    {
                        this.socialSecurityNumberField = value;
                        this.OnPropertyChanged("SocialSecurityNumber");
                    }
                }
                else
                {
                    this.socialSecurityNumberField = value;
                    this.OnPropertyChanged("SocialSecurityNumber");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Initials
        {
            get
            {
                return this.initialsField;
            }
            set
            {
                if ((this.initialsField != null))
                {
                    if ((initialsField.Equals(value) != true))
                    {
                        this.initialsField = value;
                        this.OnPropertyChanged("Initials");
                    }
                }
                else
                {
                    this.initialsField = value;
                    this.OnPropertyChanged("Initials");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public BankAccountInfoType BankAccountInfo
        {
            get
            {
                return this.bankAccountInfoField;
            }
            set
            {
                if ((this.bankAccountInfoField != null))
                {
                    if ((bankAccountInfoField.Equals(value) != true))
                    {
                        this.bankAccountInfoField = value;
                        this.OnPropertyChanged("BankAccountInfo");
                    }
                }
                else
                {
                    this.bankAccountInfoField = value;
                    this.OnPropertyChanged("BankAccountInfo");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public NationalityType Nationality
        {
            get
            {
                return this.nationalityField;
            }
            set
            {
                if ((this.nationalityField != null))
                {
                    if ((nationalityField.Equals(value) != true))
                    {
                        this.nationalityField = value;
                        this.OnPropertyChanged("Nationality");
                    }
                }
                else
                {
                    this.nationalityField = value;
                    this.OnPropertyChanged("Nationality");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public NocoreLocationType Location
        {
            get
            {
                return this.locationField;
            }
            set
            {
                if ((this.locationField != null))
                {
                    if ((locationField.Equals(value) != true))
                    {
                        this.locationField = value;
                        this.OnPropertyChanged("Location");
                    }
                }
                else
                {
                    this.locationField = value;
                    this.OnPropertyChanged("Location");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PaymentPeriod
        {
            get
            {
                return this.paymentPeriodField;
            }
            set
            {
                if ((this.paymentPeriodField != null))
                {
                    if ((paymentPeriodField.Equals(value) != true))
                    {
                        this.paymentPeriodField = value;
                        this.OnPropertyChanged("PaymentPeriod");
                    }
                }
                else
                {
                    this.paymentPeriodField = value;
                    this.OnPropertyChanged("PaymentPeriod");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PlaceOfBirth
        {
            get
            {
                return this.placeOfBirthField;
            }
            set
            {
                if ((this.placeOfBirthField != null))
                {
                    if ((placeOfBirthField.Equals(value) != true))
                    {
                        this.placeOfBirthField = value;
                        this.OnPropertyChanged("PlaceOfBirth");
                    }
                }
                else
                {
                    this.placeOfBirthField = value;
                    this.OnPropertyChanged("PlaceOfBirth");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CountryOfBirthCode
        {
            get
            {
                return this.countryOfBirthCodeField;
            }
            set
            {
                if ((this.countryOfBirthCodeField != null))
                {
                    if ((countryOfBirthCodeField.Equals(value) != true))
                    {
                        this.countryOfBirthCodeField = value;
                        this.OnPropertyChanged("CountryOfBirthCode");
                    }
                }
                else
                {
                    this.countryOfBirthCodeField = value;
                    this.OnPropertyChanged("CountryOfBirthCode");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                if ((this.statusField != null))
                {
                    if ((statusField.Equals(value) != true))
                    {
                        this.statusField = value;
                        this.OnPropertyChanged("Status");
                    }
                }
                else
                {
                    this.statusField = value;
                    this.OnPropertyChanged("Status");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("FaseHistorie", Order = 10)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<FasePeriodType> FaseHistorie
        {
            get
            {
                return this.faseHistorieField;
            }
            set
            {
                if ((this.faseHistorieField != null))
                {
                    if ((faseHistorieField.Equals(value) != true))
                    {
                        this.faseHistorieField = value;
                        this.OnPropertyChanged("FaseHistorie");
                    }
                }
                else
                {
                    this.faseHistorieField = value;
                    this.OnPropertyChanged("FaseHistorie");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MaritalStatus
        {
            get
            {
                return this.maritalStatusField;
            }
            set
            {
                if ((this.maritalStatusField != null))
                {
                    if ((maritalStatusField.Equals(value) != true))
                    {
                        this.maritalStatusField = value;
                        this.OnPropertyChanged("MaritalStatus");
                    }
                }
                else
                {
                    this.maritalStatusField = value;
                    this.OnPropertyChanged("MaritalStatus");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 12)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool TaxReduction
        {
            get
            {
                return this.taxReductionField;
            }
            set
            {
                if ((taxReductionField.Equals(value) != true))
                {
                    this.taxReductionField = value;
                    this.OnPropertyChanged("TaxReduction");
                }
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool TaxReductionSpecified
        {
            get
            {
                return this.taxReductionFieldSpecified;
            }
            set
            {
                if ((taxReductionFieldSpecified.Equals(value) != true))
                {
                    this.taxReductionFieldSpecified = value;
                    this.OnPropertyChanged("TaxReductionSpecified");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(DataType = "date", Order = 13)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime ContractEndDate
        {
            get
            {
                return this.contractEndDateField;
            }
            set
            {
                if ((contractEndDateField.Equals(value) != true))
                {
                    this.contractEndDateField = value;
                    this.OnPropertyChanged("ContractEndDate");
                }
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool ContractEndDateSpecified
        {
            get
            {
                return this.contractEndDateFieldSpecified;
            }
            set
            {
                if ((contractEndDateFieldSpecified.Equals(value) != true))
                {
                    this.contractEndDateFieldSpecified = value;
                    this.OnPropertyChanged("ContractEndDateSpecified");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 14)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public float ContractHoursPerWeek
        {
            get
            {
                return this.contractHoursPerWeekField;
            }
            set
            {
                if ((contractHoursPerWeekField.Equals(value) != true))
                {
                    this.contractHoursPerWeekField = value;
                    this.OnPropertyChanged("ContractHoursPerWeek");
                }
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool ContractHoursPerWeekSpecified
        {
            get
            {
                return this.contractHoursPerWeekFieldSpecified;
            }
            set
            {
                if ((contractHoursPerWeekFieldSpecified.Equals(value) != true))
                {
                    this.contractHoursPerWeekFieldSpecified = value;
                    this.OnPropertyChanged("ContractHoursPerWeekSpecified");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 15)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Modified
        {
            get
            {
                return this.modifiedField;
            }
            set
            {
                if ((modifiedField.Equals(value) != true))
                {
                    this.modifiedField = value;
                    this.OnPropertyChanged("Modified");
                }
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.nocore.nl/2010-10")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.nocore.nl/2010-10", IsNullable = true)]
    [System.Runtime.Serialization.DataContractAttribute(Name = "FasePeriodType", Namespace = "http://www.nocore.nl/2010-10")]
    public partial class FasePeriodType : EntityBase<FasePeriodType>
    {

        private string faseField;

        private System.DateTime fromField;

        private System.DateTime toField;

        private bool toFieldSpecified;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Fase
        {
            get
            {
                return this.faseField;
            }
            set
            {
                if ((this.faseField != null))
                {
                    if ((faseField.Equals(value) != true))
                    {
                        this.faseField = value;
                        this.OnPropertyChanged("Fase");
                    }
                }
                else
                {
                    this.faseField = value;
                    this.OnPropertyChanged("Fase");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(DataType = "date", Order = 1)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime From
        {
            get
            {
                return this.fromField;
            }
            set
            {
                if ((fromField.Equals(value) != true))
                {
                    this.fromField = value;
                    this.OnPropertyChanged("From");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(DataType = "date", Order = 2)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime To
        {
            get
            {
                return this.toField;
            }
            set
            {
                if ((toField.Equals(value) != true))
                {
                    this.toField = value;
                    this.OnPropertyChanged("To");
                }
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool ToSpecified
        {
            get
            {
                return this.toFieldSpecified;
            }
            set
            {
                if ((toFieldSpecified.Equals(value) != true))
                {
                    this.toFieldSpecified = value;
                    this.OnPropertyChanged("ToSpecified");
                }
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.nocore.nl/2010-10")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.nocore.nl/2010-10", IsNullable = true)]
    [System.Runtime.Serialization.DataContractAttribute(Name = "NationalityType", Namespace = "http://www.nocore.nl/2010-10")]
    public partial class NationalityType : EntityBase<NationalityType>
    {

        private string gBACodeField;

        private string nameField;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string GBACode
        {
            get
            {
                return this.gBACodeField;
            }
            set
            {
                if ((this.gBACodeField != null))
                {
                    if ((gBACodeField.Equals(value) != true))
                    {
                        this.gBACodeField = value;
                        this.OnPropertyChanged("GBACode");
                    }
                }
                else
                {
                    this.gBACodeField = value;
                    this.OnPropertyChanged("GBACode");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
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
    }
}
