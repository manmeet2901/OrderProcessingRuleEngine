using OrderProcessingRuleEngine.Models;
using System;
using System.Collections.Generic;

namespace OrderProcessingRuleEngine.Rules
{
    // rule for physical product
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

        public virtual List<RuleResult> Process(Order order)
        {
            GeneratePackingSlipForShipping();

            GenerateCommissionPaymentForAgent();

            throw new NotImplementedException();
        }
    }
}