using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Microsoft.EntityFrameworkCore;
using System;
using System.Globalization;
namespace AppForSpiff.Models
{

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
        public string fmt_Five_Plus => string.Format(CultureInfo.CurrentCulture, "{0:C}", Five_Plus);
        public decimal Under_Five { get; set; }
        public string fmt_Under_Five => string.Format(CultureInfo.CurrentCulture, "{0:C}", Under_Five);
        public int Required_Channel { get; set; }
        public decimal? Min_Sell_Price_Car { get; set; }
        public string fmt_Min_Sell_Price_Car => string.Format(CultureInfo.CurrentCulture, "{0:C}", Min_Sell_Price_Car);
        public decimal? Min_Sell_Price_Truck { get; set; }
        public string fmt_Min_Sell_Price_Truck => string.Format(CultureInfo.CurrentCulture, "{0:C}", Min_Sell_Price_Truck);
    }
}

