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
    }
}
