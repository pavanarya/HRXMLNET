// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.0.33213
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


    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.450")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://ns.hr-xml.org/2007-04-15")]
    [System.Xml.Serialization.XmlRootAttribute("TimecardAdditionalXX", Namespace = "http://ns.hr-xml.org/2007-04-15", IsNullable = false)]
    [System.Runtime.Serialization.DataContractAttribute(Name = "TimecardAdditionalXXType", Namespace = "http://ns.hr-xml.org/2007-04-15")]
    public partial class TimecardAdditionalXXType : EntityBase<TimecardAdditionalXXType>
    {

        private string ownerField;

        private string remarkField;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Owner
        {
            get
            {
                return this.ownerField;
            }
            set
            {
                if ((this.ownerField != null))
                {
                    if ((ownerField.Equals(value) != true))
                    {
                        this.ownerField = value;
                        this.OnPropertyChanged("Owner");
                    }
                }
                else
                {
                    this.ownerField = value;
                    this.OnPropertyChanged("Owner");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Remark
        {
            get
            {
                return this.remarkField;
            }
            set
            {
                if ((this.remarkField != null))
                {
                    if ((remarkField.Equals(value) != true))
                    {
                        this.remarkField = value;
                        this.OnPropertyChanged("Remark");
                    }
                }
                else
                {
                    this.remarkField = value;
                    this.OnPropertyChanged("Remark");
                }
            }
        }
    }
}