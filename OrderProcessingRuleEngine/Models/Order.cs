using System.Collections.Generic;

namespace OrderProcessingRuleEngine.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public Customer Customer { get; set; }
        public List<Product> Product { get; set; }
        public object Invoice { get; set; }
    }
}