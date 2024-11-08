using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Microsoft.EntityFrameworkCore;
using System;
namespace AppForSpiff.Models;

[Table("MainData_Services")] // Specify the actual table name here
public class MainDataService
{
    [Key]
    public long Service_ID { get; set; }
    public string? DealerCode { get; set; }
    public string? ServiceCode { get; set; }
    public string? ServiceName { get; set; }
    public string? Description { get; set; }
    public int Required_Channel { get; set; }
    public decimal Min_Sell_Price { get; set; }
}

