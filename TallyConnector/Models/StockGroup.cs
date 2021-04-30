﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TallyConnector.Models
{
    [XmlRoot(ElementName = "STOCKGROUP")]
    public class StockGroup:TallyXmlJson
    {
        public StockGroup()
        {
            BaseUnit = "";
        }

        [XmlAttribute(AttributeName = "ID")]
        public int TallyId { get; set; }

        [XmlAttribute(AttributeName = "NAME")]
        public string Name { get; set; }

        [XmlAttribute(AttributeName = "REQNAME")]
        public string VName { get; set; }

        [XmlElement(ElementName = "PARENT")]
        public string Parent { get; set; }


        [XmlElement(ElementName = "ISADDABLE")]
        public string IsAddable { get; set; }  //Should Quantities of Items be Added

        [XmlElement(ElementName = "GSTAPPLICABLE")]
        public string GSTApplicability { get; set; }
        
        [XmlElement(ElementName = "BASEUNITS")]
        public string BaseUnit { get; set; }


        [XmlIgnore]
        public string Alias
        {
            get
            {
                if (this.LanguageNameList.NameList.NAMES.Count > 0)
                {
                    if (VName == null)
                    {
                        VName = this.LanguageNameList.NameList.NAMES[0];
                    }
                    if (Name == VName)
                    {
                        this.LanguageNameList.NameList.NAMES[0] = this.Name;
                        return string.Join("\n", this.LanguageNameList.NameList.NAMES.GetRange(1, this.LanguageNameList.NameList.NAMES.Count - 1));

                    }
                    else
                    {
                        //Name = this.LanguageNameList.NameList.NAMES[0];
                        return string.Join("\n", this.LanguageNameList.NameList.NAMES);

                    }
                }
                else
                {
                    this.LanguageNameList.NameList.NAMES.Add(this.Name);
                    return null;
                }


            }
            set
            {
                this.LanguageNameList = new LanguageNameList();
                
                if (value != null)
                {
                    List<string> lis = value.Split('\n').ToList();

                    LanguageNameList.NameList.NAMES.Add(Name);
                    if (value != "")
                    {
                        LanguageNameList.NameList.NAMES.AddRange(lis);
                    }

                }
                else
                {
                    LanguageNameList.NameList.NAMES.Add(Name);
                }


            }
        }

        [JsonIgnore]
        [XmlElement(ElementName = "LANGUAGENAME.LIST")]
        public LanguageNameList LanguageNameList { get; set; }
        /// <summary>
        /// Accepted Values //Create, Alter, Delete
        /// </summary>
        [XmlAttribute(AttributeName = "Action")]
        public string Action { get; set; }
    }
    
    
    [XmlRoot(ElementName = "ENVELOPE")]
    public class StockGrpEnvelope : TallyXmlJson
    {

        [XmlElement(ElementName = "HEADER")]
        public Header Header { get; set; }

        [XmlElement(ElementName = "BODY")]
        public SGBody Body { get; set; } = new SGBody();
    }

    [XmlRoot(ElementName = "BODY")]
    public class SGBody
    {
        [XmlElement(ElementName = "DESC")]
        public Description Desc { get; set; } = new Description();

        [XmlElement(ElementName = "DATA")]
        public SGData Data { get; set; } = new SGData();
    }

    [XmlRoot(ElementName = "DATA")]
    public class SGData
    {
        [XmlElement(ElementName = "TALLYMESSAGE")]
        public SGMessage Message { get; set; } = new SGMessage();
    }

    [XmlRoot(ElementName = "TALLYMESSAGE")]
    public class SGMessage
    {
        [XmlElement(ElementName = "STOCKGROUP")]
        public StockGroup StockGroup { get; set; }
    }
}
