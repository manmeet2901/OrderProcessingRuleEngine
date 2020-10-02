using OrderProcessingRuleEngine.Models;
using System.Collections.Generic;

namespace OrderProcessingRuleEngine
{
    public interface IOrderProcessingRule
    {
        string RuleName { get; set; }
        List<RuleResult> Process(Order order);
    }
}