using OrderProcessingRuleEngine.Models;
using System.Collections.Generic;

namespace OrderProcessingRuleEngine
{
    public interface IOrdPrcsgRulesRepository
    {
        List<IOrderProcessingRule> GetRules(List<string> ruleNames);
        List<RuleResult> RunRules(List<IOrderProcessingRule> rules, Order order);
    }
}
