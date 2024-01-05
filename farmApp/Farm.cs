using System;
using System.Formats.Asn1;
namespace Name
{
  public enum FarmType{
        crop,
        Livestock,
        poutry,
        Potato,
        cattle
    }
    public class Farm
{
    public string FarmName { get; set; }
    public FarmType FarmType { get; set; }
    public string ManagerName { get; set; }
    public int  ManagerNumber {get; set;}
    public string Address { get; set; }
    public string YearOfEst { get; set; }
    public string FarmProduce { get; set; }
}

//List<Farm> FarmList = new List<Farm>()

}