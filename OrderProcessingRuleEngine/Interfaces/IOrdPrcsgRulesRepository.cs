using System.Collections.Generic;

namespace OrderProcessingRuleEngine
{
    public interface IOrdPrcsgRulesRepository
    {
        List<IOrderProcessingRule> GetRules(List<string> ruleNames);
        void RunRules(List<IOrderProcessingRule> rules);
    }
}
