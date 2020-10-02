using OrderProcessingRuleEngine.Models;

namespace OrderProcessingRuleEngine
{
    public interface IOrderProcessingRule
    {
        void Process(Order order);
    }
}