using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppForSpiff.Models;

using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;

public class MainData
{
    [Key]
    public long InvoiceHeader_Service_ID { get; set; }
    public long Inv_InvoiceHeader_ID { get; set; }
    public string? DealerCode { get; set; }
    public long? SalesmanEmployee_ID { get; set; }
    public long? CashoutEmployee_ID { get; set; }
    public long? InspectedByEmployee_ID { get; set; }
    public int Channel_Number { get; set; }
    public DateOnly? InvoiceCompletedDateTime_Loc { get; set; }
    public string? InvoiceNumber { get; set; }
    public decimal SumTotalInvoiceDiscountApplied_Stage04 { get; set; }
    public decimal TotalPackageLineCoupon { get; set; }
    public decimal TotalPackageLineDiscount { get; set; }
    public decimal TotalInvoiceCoupon { get; set; }
    public decimal TotalInvoiceDiscount { get; set; }
    public decimal InvoiceTotal { get; set; }
    public decimal TotalAmountPaid { get; set; }
    public int? TotalServiceLines { get; set; }
    public int? TotalPartLines { get; set; }
    public long? Employee_ID { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Role { get; set; }
    public DateTime? TerminationDate_Loc { get; set; }
    public long? PackageItem_ID { get; set; }
    public long? Svs_Service_ID { get; set; }
    public long? Svs_GLAccountList_ID { get; set; }
    public long? Svs_InvoiceHeader_ID { get; set; }
    public int? LineNumber { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal? UnitPrice_ForAssociateCustomerOnly { get; set; }
    public decimal Quantity { get; set; }
    public decimal GrossTotal { get; set; }
    public decimal CouponAmount_LineItemLevel { get; set; }
    public decimal CouponPercent_LineItemLevel { get; set; }
    public decimal TotalLineCouponApplied_Stage01 { get; set; }
    public decimal CouponAmount_InvoiceLevel { get; set; }
    public decimal CouponPercent_InvoiceLevel { get; set; }
    public decimal TotalInvoiceCouponApplied_Stage02 { get; set; }
    public decimal DiscountAmount_LineItemLevel { get; set; }
    public decimal DiscountPercent_LineItemLevel { get; set; }
    public decimal TotalLineDiscountApplied_Stage03 { get; set; }
    public decimal DiscountAmount_InvoiceLevel { get; set; }
    public decimal DiscountPercent_InvoiceLevel { get; set; }
    public decimal TotalInvoiceDiscountApplied_Stage04 { get; set; }
    public long? SalespersonEmployee_ID { get; set; }
    public string? ServiceCode { get; set; }
    public string? ServiceName { get; set; }
    public string? Description { get; set; }
}




