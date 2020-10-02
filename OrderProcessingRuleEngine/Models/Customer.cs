namespace OrderProcessingRuleEngine.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string EmailID { get; set; }
        public string MobileNumber { get; set; }
        public string BillingAddress { get; set; }
        public string ShippingAddress { get; set; }
    }
}