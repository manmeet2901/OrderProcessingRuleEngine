using OrderProcessingRuleEngine.Models;
using System.Collections.Generic;

namespace OrderProcessingRuleEngine.Rules
{
    // rule for physical product
    public class GoodsOrderProcessingRule : IOrderProcessingRule
    {
        public string RuleName { get; set; }

        public GoodsOrderProcessingRule(string ruleName)
        {
            RuleName = ruleName;
        }

        protected string GenerateCommissionPaymentForAgent()
        {
            return "Generated commission payment to the agent.";
        }

        protected string GeneratePackingSlipForShipping()
        {
            return "Generated packing slip for shipping.";
        }

        public virtual List<RuleResult> Process(Order order)
        {
            return new List<RuleResult>
            {
                RuleResult.GetInstance(RuleName, GeneratePackingSlipForShipping()),
                RuleResult.GetInstance(RuleName, GenerateCommissionPaymentForAgent())
            };
        }
    }
}