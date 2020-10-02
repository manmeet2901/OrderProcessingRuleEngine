using OrderProcessingRuleEngine.Models;
using System.Collections.Generic;

namespace OrderProcessingRuleEngine.Rules
{
    // abstract rule for physical product
    public abstract class GoodsOrderProcessingRule : IOrderProcessingRule
    {
        public abstract string RuleName { get; set; }

        protected string GenerateCommissionPaymentForAgent()
        {
            return "Generated commission payment to the agent";
        }

        protected string GeneratePackingSlipForShipping()
        {
            return "Generated packing slip for shipping.";
        }

        public abstract List<RuleResult> Process(Order order);
    }
}