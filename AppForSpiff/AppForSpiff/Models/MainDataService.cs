using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Microsoft.EntityFrameworkCore;
using System;
using System.Globalization;

namespace AppForSpiff.Models
{
    [Table("MainData_Services")] // Specify the actual table name here
    public class MainDataService
    {
        [Key]
        public long Service_ID { get; set; }
        public string? DealerCode { get; set; }
        public string? ServiceCode { get; set; }
        public string? ServiceName { get; set; }
        public string? Description { get; set; }
        public int? Required_Channel { get; set; }
        public decimal? Min_Sell_Price_Car { get; set; }
        public string fmt_Min_Sell_Price_Car => string.Format(CultureInfo.CurrentCulture, "{0:C}", Min_Sell_Price_Car);
        public decimal? Min_Sell_Price_Truck { get; set; }
        public string fmt_Min_Sell_Price_Truck => string.Format(CultureInfo.CurrentCulture, "{0:C}", Min_Sell_Price_Truck);
        public decimal? ComAmount { get; set; }
        public string fmt_ComAmount => string.Format(CultureInfo.CurrentCulture, "{0:C}", ComAmount);
        public double? ComMinPercent { get; set; }
        public double? ComMaxPercent { get; set; }

    }
}

