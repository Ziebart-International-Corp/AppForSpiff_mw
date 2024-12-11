using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;

namespace AppForSpiff.Data
{
    public class ChemAccData
    {
        [Key]
        public long UniqueKey { get; set; }
        public string? DealerCode { get; set; }
        public string? ServiceCode { get; set; }
        public string? ServiceName { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? Amount { get; set; }
        public string? Status { get; set; }
    }
    public class ChemData
    {
        [Key]
        public long UniqueKey { get; set; }
        public string? Dealer_Code { get; set; }
        public decimal? Chemicals { get; set; }
        public decimal? Chemical_hold { get; set; }
        public decimal? Chem_Inc_Dec { get; set; }
        public decimal? Store_Chem_Percent { get; set; }
        public decimal? Chem_Subtotal { get; set; }
        public string? First_Name { get; set; }
        public string? Last_Name { get; set; }
        public decimal? Chem_Emp_Percent { get; set; }
        public decimal? Chem_Bonus { get; set; }
    }

    public class AccData
    {
        [Key]
        public long UniqueKey { get; set; }
        public string? Dealer_Code { get; set; }
        public decimal? Accessories { get; set; }
        public decimal? Accessories_hold { get; set; }
        public decimal? Acc_Inc_Dec { get; set; }
        public decimal? Store_Acc_Percent { get; set; }
        public decimal? Acc_Subtotal { get; set; }
        public string? First_Name { get; set; }
        public string? Last_Name { get; set; }
        public decimal? Acc_Emp_Percent { get; set; }
        public decimal? Acc_Bonus { get; set; }
    }


    public class PackagesData
    {
        [Key]
        public long UniqueKey { get; set; }
        public string? DealerCode { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public int? InvoiceNumber { get; set; }
        public string? Title { get; set; }
        public decimal? PackageTotal { get; set; }
        public string? Model { get; set; }
        public string? VehicleTypeName { get; set; }
        public int? Group_1_Package_Count { get; set; }
        public int? Group_2_Package_Count { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public decimal? Commission { get; set; }
    }


    public class ServiceCodesData
    {
        [Key]
        public long UniqueKey { get; set; }
        public string? DealerCode { get; set; }
        public int? InvoiceNumber { get; set; }
        public string? ServiceCode { get; set; }
        public string? ServiceName { get; set; }
        public decimal? SalesPrice { get; set; }
        public decimal? Quantity { get; set; }
        public string? Model { get; set; }
        public string? VehicleTypeName { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public decimal? Commission { get; set; }
    }

    public class ServiceCodesPctData
    {
        [Key]
        public long UniqueKey { get; set; }
        public string? DealerCode { get; set; }
        public int? InvoiceNumber { get; set; }
        public string? ServiceCode { get; set; }
        public string? ServiceName { get; set; }
        public decimal? SalesPrice { get; set; }
        public decimal? Quantity { get; set; }
        public string? Model { get; set; }
        public string? VehicleTypeName { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public decimal? Commission { get; set; }
    }

    public class GrandTotalsData
    {
        [Key]
        public long FIN_UNIQUE_KEY { get; set; }
        public string? FIN_DEALER_CODE { get; set; }
        public string? FIN_FIRST_NAME { get; set; }
        public string? FIN_LAST_NAME { get; set; }
        public decimal? FIN_CHEM_BONUS { get; set; }
        public decimal? FIN_ACC_BONUS { get; set; }
        public decimal? PKG_Commission { get; set; }
        public decimal? SVS_Commission { get; set; }
        public decimal? SVS_PCT_Commission { get; set; }
        public decimal? GRAND_TOTAL { get; set; }
    }


}

