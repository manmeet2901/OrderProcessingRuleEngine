using OrderProcessingRuleEngine.Models;
using System;
using System.Collections.Generic;

namespace OrderProcessingRuleEngine.Rules
{
    // rule for the video "Learning to Ski,"
    public class LearningToSkiVideoOrderProcessingRule : GoodsOrderProcessingRule
    {
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