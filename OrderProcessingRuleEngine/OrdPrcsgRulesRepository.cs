using OrderProcessingRuleEngine.Models;
using OrderProcessingRuleEngine.Rules;
using System.Collections.Generic;

namespace OrderProcessingRuleEngine
{
    public class OrdPrcsgRulesRepository : IOrdPrcsgRulesRepository
    {
        public List<IOrderProcessingRule> GetRules(List<string> ruleNames)
        {
            List<IOrderProcessingRule> rules = new List<IOrderProcessingRule>();

            foreach(string ruleName in ruleNames)
            {
                bool hasRule = GetAllRules().TryGetValue(ruleName, out IOrderProcessingRule rule);

                if (hasRule)
                    rules.Add(rule);
            }

            return rules;
        }

        public List<RuleResult> RunRules(List<IOrderProcessingRule> rules, Order order)
        {
            List<RuleResult> results = new List<RuleResult>();

            foreach (IOrderProcessingRule rule in rules)
                results.AddRange(rule.Process(order));

            return results;
        }

        private Dictionary<string, IOrderProcessingRule> GetAllRules()
        {
            // add more rules here
            return new Dictionary<string, IOrderProcessingRule>()
            {
                { "PHYS_PROD", new GoodsOrderProcessingRule("PHYS_PROD") },
                { "BOOK", new BookOrderProcessingRule("BOOK") },
                { "MEM_ACT", new MembershipOrderProcessingRule("MEM_ACT") },
                { "MEM_UPG", new MembershipUpgradeOrderProcessingRule("MEM_UPG") },
                { "VIDLEARNTOSKI", new LearningToSkiVideoOrderProcessingRule("VIDLEARNTOSKI")}
            };
        }
    }
}