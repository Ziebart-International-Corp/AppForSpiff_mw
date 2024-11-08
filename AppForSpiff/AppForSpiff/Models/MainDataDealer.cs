using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Microsoft.EntityFrameworkCore;
using System;
namespace AppForSpiff.Models;

[Table("MainData_Dealers")] // Specify the actual table name here
public class MainDataDealer
{
    [Key]
    public long Dealer_ID { get; set; }
    public string? DealerCode { get; set; }
    public decimal StoreHold_Chemical { get; set; }
    public decimal StoreHold_Accessories { get; set; }
    public double Store_Chemical_Percent { get; set; }
    public double Store_Accessories_Percent { get; set; }
}

