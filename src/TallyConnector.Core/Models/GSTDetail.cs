﻿namespace TallyConnector.Core.Models;

[XmlRoot(ElementName = "GSTDETAILS.LIST")]
public class GSTDetail : TallyBaseObject, ICheckNull
{
    [XmlElement(ElementName = "APPLICABLEFROM")]
    public TallyDate? ApplicableFrom { get; set; }

    [XmlElement(ElementName = "CALCULATIONTYPE")]
    public string? CalculationType { get; set; }

    [XmlElement(ElementName = "HSNCODE")]
    public string? HSNCode { get; set; }

    [XmlElement(ElementName = "HSN")]
    public string? HSNDescription { get; set; }

    [XmlElement(ElementName = "HSNMASTERNAME")]
    public string? HSNMasterName { get; set; }

    [XmlElement(ElementName = "ISNONGSTGOODS")]
    public TallyYesNo? IsNonGSTGoods { get; set; }

    [XmlElement(ElementName = "TAXABILITY")]
    public GSTTaxabilityType Taxability { get; set; }
    [XmlElement(ElementName = "SRCOFGSTDETAILS")]
    public string? SourceOfGSTDetails { get; set; }

    [XmlElement(ElementName = "ISREVERSECHARGEAPPLICABLE")]
    public TallyYesNo? IsReverseChargeApplicable { get; set; }

    [XmlElement(ElementName = "GSTINELIGIBLEITC")]
    public TallyYesNo? IsInEligibleforITC { get; set; }

    [XmlElement(ElementName = "INCLUDEEXPFORSLABCALC")]
    public TallyYesNo? IcludeExpForSlabCalc { get; set; }

    [XmlElement(ElementName = "STATEWISEDETAILS.LIST")]
    public List<StateWiseDetail>? StateWiseDetails { get; set; }

    public bool IsNull()
    {
        return false;
    }
}

[XmlRoot(ElementName = "STATEWISEDETAILS.LIST")]
public class StateWiseDetail
{
    [XmlElement(ElementName = "STATENAME")]
    public string? StateName { get; set; }

    [XmlElement(ElementName = "RATEDETAILS.LIST")]
    public List<GSTRateDetail>? GSTRateDetails { get; set; }


}

[XmlRoot(ElementName = "RATEDETAILS.LIST")]
public class GSTRateDetail
{
    [XmlElement(ElementName = "GSTRATEDUTYHEAD")]
    public string? DutyHead { get; set; }

    [XmlElement(ElementName = "GSTRATEVALUATIONTYPE")]
    public string? ValuationType { get; set; }

    [XmlElement(ElementName = "GSTRATE")]
    public double GSTRate { get; set; }
}


/// <summary>
/// <para> GST TaxabilityTypes as per  Tally</para>
///  <para>TDL Reference -  "DEFTDL:src\master\gstclassification\gstclassificationcoll.tdl"
///  Search using "GSTTaxType"</para>
/// </summary>
public enum GSTTaxabilityType
{
    [XmlEnum(Name = "")]
    None = 0,
    [XmlEnum(Name = "Taxable")]
    Taxable = 1,
    [XmlEnum(Name = "Exempt")]
    Exempt = 2,
    [XmlEnum(Name = "Nil Rated")]
    NilRated = 3,
    [XmlEnum(Name = "Unknown")]
    Unknown = 4,
    [XmlEnum(Name = "Non-GST")]
    NONGST = 5,

}
