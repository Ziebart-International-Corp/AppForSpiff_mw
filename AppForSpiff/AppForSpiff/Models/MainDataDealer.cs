using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Microsoft.EntityFrameworkCore;
using System;
using System.Globalization;

namespace AppForSpiff.Models
{

    [Table("MainData_Dealers")] // Specify the actual table name here
    public class MainDataDealer
    {
        [Key]
        public long Dealer_ID { get; set; }
        public string? DealerCode { get; set; }
        public decimal StoreHold_Chemical { get; set; }
        public string fmt_StoreHold_Chemical => string.Format(CultureInfo.CurrentCulture, "{0:C}", StoreHold_Chemical);
        public decimal StoreHold_Accessories { get; set; }
        public string fmt_StoreHold_Accessories => string.Format(CultureInfo.CurrentCulture, "{0:C}", StoreHold_Accessories);
        public double Store_Chemical_Percent { get; set; }
        public double Store_Accessories_Percent { get; set; }
    }
}

