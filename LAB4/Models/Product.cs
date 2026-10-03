namespace eSHOPPING.Models
{
    public class Product
    {
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string Manufacturer { get; set; }
        public decimal CurrentPrice { get; set; }
        public string StockStatus { get; set; }
    }
}