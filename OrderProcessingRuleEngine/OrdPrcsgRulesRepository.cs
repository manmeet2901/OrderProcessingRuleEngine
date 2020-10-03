using OrderProcessingRuleEngine.Rules;
using System.Collections.Generic;

namespace OrderProcessingRuleEngine
{
    public class OrdPrcsgRulesRepository : IOrdPrcsgRulesRepository
    {
        public List<IOrderProcessingRule> GetRules(List<string> ruleNames)
        {
            throw new System.NotImplementedException();
        }

        public void RunRules(List<IOrderProcessingRule> rules)
        {
            throw new System.NotImplementedException();
        }

        private Dictionary<string, IOrderProcessingRule> GetAllRules()
        {
            // add more rules here
            return new Dictionary<string, IOrderProcessingRule>()
            {
                { "PHYS_PROD", new GoodsOrderProcessingRule() },
                { "BOOK", new BookOrderProcessingRule() },
                { "MEM_ACT", new MembershipOrderProcessingRule() },
                { "MEM_UPG", new MembershipUpgradeOrderProcessingRule() },
                { "VIDLEARNTOSKI", new LearningToSkiVideoOrderProcessingRule()}
            };
        }
    }
}