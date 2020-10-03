using OrderProcessingRuleEngine.Models;
using System;
using System.Collections.Generic;

namespace OrderProcessingRuleEngine.Rules
{
    // rule for the video "Learning to Ski,"
    public class LearningToSkiVideoOrderProcessingRule : GoodsOrderProcessingRule
    {
        public LearningToSkiVideoOrderProcessingRule(string ruleName): base(ruleName)
        {

        }

        private string AddFreeFirstAidVideoToPackingSlip()
        {
            return "Added free 'First Aid' video to the packing slip";
        }

        public override List<RuleResult> Process(Order order)
        {
            base.Process(order);

            AddFreeFirstAidVideoToPackingSlip();

            throw new NotImplementedException();
        }
    }
}