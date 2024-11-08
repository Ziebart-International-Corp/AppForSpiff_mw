using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Microsoft.EntityFrameworkCore;
using System;
namespace AppForSpiff.Models;

[Table("MainData_Employees")] // Specify the actual table name here
public class MainDataEmployee
{
    [Key]
    public long Edl_Employee_ID { get; set; }
    public string? DealerCode { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public double? Spiff_Percent { get; set; }
}

