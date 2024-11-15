using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Microsoft.EntityFrameworkCore;
using System;

namespace AppForSpiff.Models
{

    public class MainData
    {
        [Key]
        public long InvoiceHeader_Service_ID { get; set; }
        public long Inv_InvoiceHeader_ID { get; set; }
        public string? DealerCode { get; set; }
        public long? SalesmanEmployee_ID { get; set; }
        public int Channel_Number { get; set; }
        public DateOnly? InvoiceDate { get; set; }
        public string? InvoiceNumber { get; set; }
        public decimal InvoiceTotal { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public long? PackageItem_ID { get; set; }
        public long? Svs_Service_ID { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Quantity { get; set; }
        public decimal TotalInvoiceDiscountApplied_Stage04 { get; set; }
        public string? ServiceCode { get; set; }
        public string? ServiceName { get; set; }
        public string? Description { get; set; }
        public string? Make { get; set; }
        public string? Model { get; set; }
        public string? VehicleTypeName { get; set; }
        public string? PackageName { get; set; }
    }
}




