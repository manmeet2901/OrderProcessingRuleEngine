using OrderProcessingRuleEngine.Models;

namespace OrderProcessingRuleEngine.Rules
{
    // rule for physical product
    public abstract class GoodsOrderProcessingRule : IOrderProcessingRule
    {
        protected string GeneratePackingSlip()
        {
            return "Generated a packing slip for shipping.";
        }

        public abstract void Process(Order order);
    }
}