// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.0.0.19662
//    <NameSpace>HRXML.Net</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>True</EnableDataBinding><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>True</EnableSummaryComment><IncludeSerializeMethod>True</IncludeSerializeMethod><UseBaseClass>True</UseBaseClass><GenerateCloneMethod>True</GenerateCloneMethod><GenerateDataContracts>True</GenerateDataContracts><CodeBaseTag>Net35</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>True</GenerateXMLAttributes><AutomaticProperties>False</AutomaticProperties><DisableDebug>False</DisableDebug><CustomUsings></CustomUsings>
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

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://ns.hr-xml.org/2007-04-15")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://ns.hr-xml.org/2007-04-15", IsNullable = false)]
    [System.Runtime.Serialization.DataContractAttribute(Name = "RoundingElements", Namespace = "http://ns.hr-xml.org/2007-04-15")]
    public partial class RoundingElements : EntityBase<RoundingElements>
    {

        private List<RoundingRuleType> roundingField;

        private List<TimeRoundingRuleType> timeRoundingField;

        [System.Xml.Serialization.XmlElementAttribute("Rounding")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<RoundingRuleType> Rounding
        {
            get
            {
                if ((this.roundingField == null))
                {
                    this.roundingField = new List<RoundingRuleType>();
                }
                return this.roundingField;
            }
            set
            {
                if ((this.roundingField != null))
                {
                    if ((roundingField.Equals(value) != true))
                    {
                        this.roundingField = value;
                        this.OnPropertyChanged("Rounding");
                    }
                }
                else
                {
                    this.roundingField = value;
                    this.OnPropertyChanged("Rounding");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("TimeRounding")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<TimeRoundingRuleType> TimeRounding
        {
            get
            {
                if ((this.timeRoundingField == null))
                {
                    this.timeRoundingField = new List<TimeRoundingRuleType>();
                }
                return this.timeRoundingField;
            }
            set
            {
                if ((this.timeRoundingField != null))
                {
                    if ((timeRoundingField.Equals(value) != true))
                    {
                        this.timeRoundingField = value;
                        this.OnPropertyChanged("TimeRounding");
                    }
                }
                else
                {
                    this.timeRoundingField = value;
                    this.OnPropertyChanged("TimeRounding");
                }
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://ns.hr-xml.org/2007-04-15")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "RoundingRuleType", Namespace = "http://ns.hr-xml.org/2007-04-15")]
    public partial class RoundingRuleType : EntityBase<RoundingRuleType>
    {

        private List<RoundingRuleEnumType> roundingMethodField;

        private string resultDigitField;

        [System.Xml.Serialization.XmlElementAttribute("RoundingMethod")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<RoundingRuleEnumType> RoundingMethod
        {
            get
            {
                if ((this.roundingMethodField == null))
                {
                    this.roundingMethodField = new List<RoundingRuleEnumType>();
                }
                return this.roundingMethodField;
            }
            set
            {
                if ((this.roundingMethodField != null))
                {
                    if ((roundingMethodField.Equals(value) != true))
                    {
                        this.roundingMethodField = value;
                        this.OnPropertyChanged("RoundingMethod");
                    }
                }
                else
                {
                    this.roundingMethodField = value;
                    this.OnPropertyChanged("RoundingMethod");
                }
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string resultDigit
        {
            get
            {
                return this.resultDigitField;
            }
            set
            {
                if ((this.resultDigitField != null))
                {
                    if ((resultDigitField.Equals(value) != true))
                    {
                        this.resultDigitField = value;
                        this.OnPropertyChanged("resultDigit");
                    }
                }
                else
                {
                    this.resultDigitField = value;
                    this.OnPropertyChanged("resultDigit");
                }
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://ns.hr-xml.org/2007-04-15")]
    public enum RoundingRuleEnumType
    {

        /// <remarks/>
        RoundDown,

        /// <remarks/>
        RoundHalfDown,

        /// <remarks/>
        RoundUp,

        /// <remarks/>
        RoundHalfUp,

        /// <remarks/>
        RoundHalfEven,

        /// <remarks/>
        RoundCeiling,

        /// <remarks/>
        RoundFloor,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://ns.hr-xml.org/2007-04-15")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "TimeRoundingRuleType", Namespace = "http://ns.hr-xml.org/2007-04-15")]
    public partial class TimeRoundingRuleType : EntityBase<TimeRoundingRuleType>
    {

        private TimeRoundingRuleTypeTimeInterval timeIntervalField;

        private string summaryCycleField;

        [System.Runtime.Serialization.DataMemberAttribute()]
        public TimeRoundingRuleTypeTimeInterval TimeInterval
        {
            get
            {
                return this.timeIntervalField;
            }
            set
            {
                if ((this.timeIntervalField != null))
                {
                    if ((timeIntervalField.Equals(value) != true))
                    {
                        this.timeIntervalField = value;
                        this.OnPropertyChanged("TimeInterval");
                    }
                }
                else
                {
                    this.timeIntervalField = value;
                    this.OnPropertyChanged("TimeInterval");
                }
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string summaryCycle
        {
            get
            {
                return this.summaryCycleField;
            }
            set
            {
                if ((this.summaryCycleField != null))
                {
                    if ((summaryCycleField.Equals(value) != true))
                    {
                        this.summaryCycleField = value;
                        this.OnPropertyChanged("summaryCycle");
                    }
                }
                else
                {
                    this.summaryCycleField = value;
                    this.OnPropertyChanged("summaryCycle");
                }
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://ns.hr-xml.org/2007-04-15")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "TimeRoundingRuleTypeTimeInterval", Namespace = "http://ns.hr-xml.org/2007-04-15")]
    public partial class TimeRoundingRuleTypeTimeInterval
    {

        private RoundingRuleEnumType roundingMethodField;

        private bool roundingMethodFieldSpecified;

        private string unitOfTimeField;

        private decimal valueField;

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public RoundingRuleEnumType roundingMethod
        {
            get
            {
                return this.roundingMethodField;
            }
            set
            {
                if ((roundingMethodField.Equals(value) != true))
                {
                    this.roundingMethodField = value;
                }
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool roundingMethodSpecified
        {
            get
            {
                return this.roundingMethodFieldSpecified;
            }
            set
            {
                if ((roundingMethodFieldSpecified.Equals(value) != true))
                {
                    this.roundingMethodFieldSpecified = value;
                }
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string unitOfTime
        {
            get
            {
                return this.unitOfTimeField;
            }
            set
            {
                if ((this.unitOfTimeField != null))
                {
                    if ((unitOfTimeField.Equals(value) != true))
                    {
                        this.unitOfTimeField = value;
                    }
                }
                else
                {
                    this.unitOfTimeField = value;
                }
            }
        }

        [System.Xml.Serialization.XmlTextAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                if ((valueField.Equals(value) != true))
                {
                    this.valueField = value;
                }
            }
        }
    }

}
