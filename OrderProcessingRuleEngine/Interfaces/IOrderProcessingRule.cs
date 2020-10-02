using OrderProcessingRuleEngine.Models;

namespace OrderProcessingRuleEngine
{
    public interface IOrderProcessingRule
    {
        string RuleName { get; set; }
        void Process(Order order);
    }
}