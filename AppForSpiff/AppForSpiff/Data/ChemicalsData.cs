using System.ComponentModel.DataAnnotations;

namespace AppForSpiff.Data
{
    public class ChemicalsData
    {
        [Key]
        public long UniqueKey { get; set; }
        public string? DealerCode { get; set; }
        public int Channel_Number { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string? InvoiceNumber { get; set; }
        public string? ServiceCode { get; set; }
        public string? ServiceName { get; set; }
        public decimal Line_Item_Amount { get; set; }
    }
}

