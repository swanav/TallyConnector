using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace TallyConnector.Models
{
    public class TallyList
    {

    }

   
    [XmlRoot(ElementName = "LISTOFGROUPS")]
    public class GroupsList
    {
        [XmlElement(ElementName = "NAME")]
        public List<string> GroupNames { get; set; } = new List<string>();

    }
    [XmlRoot(ElementName = "LISTOFLEDGERS")]
    public class LedgersList
    {
        [XmlElement(ElementName = "NAME")]
        public List<string> LedgerNames { get; set; } = new List<string>();

    }

    [XmlRoot(ElementName = "LISTOFCOSTCATEGORIES")]
    public class CostCategoriesList
    {
        [XmlElement(ElementName = "NAME")]
        public List<string> CostCategories { get; set; } = new List<string>();

    }

    
    [XmlRoot(ElementName = "LISTOFCOSTCENTERS")]
    public class CostCentersList
    {
        [XmlElement(ElementName = "NAME")]
        public List<string> CostCenters { get; set; } = new List<string>();

    }

    [XmlRoot(ElementName = "LISTOFSTOCKGROUPS")]
    public class StockGroupsList
    {
        [XmlElement(ElementName = "NAME")]
        public List<string> StockGroups { get; set; } = new List<string>();

    }

    [XmlRoot(ElementName = "LISTOFSTOCKCATEGORIES")]
    public class StockCategoriesList
    {
        [XmlElement(ElementName = "NAME")]
        public List<string> StockCategories { get; set; } = new List<string>();

    }
    [XmlRoot(ElementName = "LISTOFSTOCKITEMS")]
    public class StockItemsList
    {
        [XmlElement(ElementName = "NAME")]
        public List<string> StockItems { get; set; } = new List<string>();

    }

    [XmlRoot(ElementName = "LISTOFGODOWNS")]
    public class GodownsList
    {
        [XmlElement(ElementName = "NAME")]
        public List<string> Godowns { get; set; } = new List<string>();

    }

    [XmlRoot(ElementName = "LISTOFVOUCHERTYPES")]
    public class VoucherTypesList
    {
        [XmlElement(ElementName = "NAME")]
        public List<string> VoucherTypes { get; set; } = new List<string>();

    }

    [XmlRoot(ElementName = "LISTOFUNITS")]
    public class UnitsList
    {
        [XmlElement(ElementName = "NAME")]
        public List<string> Units { get; set; } = new List<string>();

    }

    [XmlRoot(ElementName = "LISTOFCURRENCIES")]
    public class CurrenciesList
    {
        [XmlElement(ElementName = "NAME")]
        public List<string> Currencies { get; set; } = new List<string>();

    }

    [XmlRoot(ElementName = "LISTOFATTENDANCETYPES")]
    public class AttendanceTypesList
    {
        [XmlElement(ElementName = "NAME")]
        public List<string> AttendanceTypes { get; set; } = new List<string>();

    }

    [XmlRoot(ElementName = "LISTOFEMPLOYEEGROUPS")]
    public class EmployeeGroupList
    {
        [XmlElement(ElementName = "NAME")]
        public List<string> EmployeeGroups { get; set; } = new List<string>();

    }

    [XmlRoot(ElementName = "LISTOFEMPLOYEES")]
    public class EmployeesList
    {
        [XmlElement(ElementName = "NAME")]
        public List<string> Employees { get; set; } = new List<string>();

    }

    [XmlRoot(ElementName = "LISTOFVOUCHERS")]
    public class VouchersList
    {

        [XmlElement(ElementName = "VOUCHERNUMBER")]
        public List<string> VoucherIds { get; set; }

        [XmlElement(ElementName = "MASTERID")]
        public List<int> MasterIDs { get; set; }
        
        [XmlElement(ElementName = "DATE")]
        public List<string> VoucherDates { get; set; }

    }

    [XmlRoot(ElementName = "ENVELOPE")]
    public class ComListEnvelope : TallyXmlJson
    {

        [XmlElement(ElementName = "HEADER")]
        public Header Header { get; set; }

        [XmlElement(ElementName = "BODY")]
        public ComListBody Body { get; set; } = new ComListBody();
    }

    [XmlRoot(ElementName = "BODY")]
    public class ComListBody
    {
        [XmlElement(ElementName = "DESC")]
        public Description Desc { get; set; } = new Description();

        [XmlElement(ElementName = "DATA")]
        public ComListData Data { get; set; } = new ComListData();
    }

    [XmlRoot(ElementName = "DATA")]
    public class ComListData
    {
        [XmlElement(ElementName = "COLLECTION")]
        public ComListColl Collection { get; set; } = new ComListColl();
    }

    [XmlRoot(ElementName = "COLLECTION")]
    public class ComListColl
    {
        [XmlElement(ElementName = "COMPANY")]
        public List<Company> CompaniesList { get; set; }
    }




}
