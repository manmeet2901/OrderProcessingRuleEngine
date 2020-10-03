using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderProcessingRuleEngine;
using OrderProcessingRuleEngine.Models;
using System.Collections.Generic;

namespace OrderProcessingRuleEngineTest
{
    [TestClass]
    public class TestGoodsOrderProcessingRule
    {
        private readonly Order _order;
        private readonly IOrdPrcsgRulesRepository _rulesRepo;

        public TestGoodsOrderProcessingRule()
        {
            _order = new Order()
            {
                Product = new List<Product>() { new Product() { ProductRules = new List<string>() { "PHYS_PROD" } } }
            };

            _rulesRepo = new OrdPrcsgRulesRepository();
        }

        [TestMethod]
        public void TestOrderProcess()
        {
            // arrange
            List<RuleResult> expectedRuleResult = new List<RuleResult>()
            {
                RuleResult.GetInstance("PHYS_PROD", "Generated packing slip for shipping."),
                RuleResult.GetInstance("PHYS_PROD", "Generated commission payment to the agent."),
            };

            List<IOrderProcessingRule> rules = new List<IOrderProcessingRule>();

            foreach (Product prod in _order.Product)
                rules = _rulesRepo.GetRules(prod.ProductRules);

            // act
            List<RuleResult> actualRuleResult = _rulesRepo.RunRules(rules, _order);

            // assert
            Assert.AreEqual(expectedRuleResult.Count, actualRuleResult.Count);
        }
    }
}
