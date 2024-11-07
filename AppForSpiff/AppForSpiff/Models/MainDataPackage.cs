using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppForSpiff.Models;

[Table("MainData_Packages")] // Specify the actual table name here
public class MainDataPackage
{
    [Key]
    public long PackageItem_ID { get; set; }
    public long P_Service_ID { get; set; }
    public string? DealerCode { get; set; }
    public string? Title { get; set; }
    public int Channel_Number { get; set; }
    public string? ServiceCode { get; set; }
    public decimal Five_Plus { get; set; }
    public decimal Under_Five { get; set; }
    public int Required_Channel { get; set; }
    public decimal Min_Sell_Price { get; set; }
}

