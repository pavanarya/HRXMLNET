//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=4.6.1055.0.
// 
namespace HRXML.Net
{
    using System.Xml.Serialization;


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.flex2go.nl/2016-06")]
    [System.Xml.Serialization.XmlRootAttribute("Flex2GoTimecard", Namespace = "http://www.flex2go.nl/2016-06", IsNullable = false)]
    public partial class Flex2GoTimecardType
    {

        private string costCenterCodeField;

        private string costCenterDescriptionField;

        private string costUnitCodeField;

        private string costUnitDescriptionField;

        private string taxHandlingCodeField;

        private string taxHandlingDescriptionField;

        /// <remarks/>
        public string CostCenterCode
        {
            get
            {
                return this.costCenterCodeField;
            }
            set
            {
                this.costCenterCodeField = value;
            }
        }

        /// <remarks/>
        public string CostCenterDescription
        {
            get
            {
                return this.costCenterDescriptionField;
            }
            set
            {
                this.costCenterDescriptionField = value;
            }
        }

        /// <remarks/>
        public string CostUnitCode
        {
            get
            {
                return this.costUnitCodeField;
            }
            set
            {
                this.costUnitCodeField = value;
            }
        }

        /// <remarks/>
        public string CostUnitDescription
        {
            get
            {
                return this.costUnitDescriptionField;
            }
            set
            {
                this.costUnitDescriptionField = value;
            }
        }

        /// <remarks/>
        public string TaxHandlingCode
        {
            get
            {
                return this.taxHandlingCodeField;
            }
            set
            {
                this.taxHandlingCodeField = value;
            }
        }

        /// <remarks/>
        public string TaxHandlingDescription
        {
            get
            {
                return this.taxHandlingDescriptionField;
            }
            set
            {
                this.taxHandlingDescriptionField = value;
            }
        }
    }
}
