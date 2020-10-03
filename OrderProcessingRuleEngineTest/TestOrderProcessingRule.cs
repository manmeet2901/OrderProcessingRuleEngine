using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderProcessingRuleEngine;
using OrderProcessingRuleEngine.Models;
using System.Collections.Generic;

namespace OrderProcessingRuleEngineTest
{
    [TestClass]
    public class TestOrderProcessingRule
    {
        private readonly IOrdPrcsgRulesRepository _rulesRepo;

        public TestOrderProcessingRule()
        {
            _rulesRepo = new OrdPrcsgRulesRepository();
        }

        [TestMethod]
        public void TestOrderProcessForPhysicalProduct()
        {
            // arrange
            List<RuleResult> expectedRuleResult = new List<RuleResult>()
            {
                RuleResult.GetInstance("PHYS_PROD", "Generated packing slip for shipping."),
                RuleResult.GetInstance("PHYS_PROD", "Generated commission payment to the agent."),
            };

            Order order = new Order()
            {
                Product = new List<Product>() { new Product() { ProductRules = new List<string>() { "PHYS_PROD" } } }
            };

            List<IOrderProcessingRule> rules = new List<IOrderProcessingRule>();

            foreach (Product prod in order.Product)
                rules = _rulesRepo.GetRules(prod.ProductRules);

            // act
            List<RuleResult> actualRuleResult = _rulesRepo.RunRules(rules, order);

            // assert
            Assert.AreEqual(expectedRuleResult.Count, actualRuleResult.Count);
        }

        [TestMethod]
        public void TestOrderProcessForBook()
        {
            // arrange
            List<RuleResult> expectedRuleResult = new List<RuleResult>()
            {
                RuleResult.GetInstance("BOOK", "Generated packing slip for shipping."),
                RuleResult.GetInstance("BOOK", "Generated commission payment to the agent."),
                RuleResult.GetInstance("BOOK", "Created duplicate packing slip for the royalty department.")
            };

            Order order = new Order()
            {
                Product = new List<Product>() { new Product() { ProductRules = new List<string>() { "BOOK" } } }
            };

            List<IOrderProcessingRule> rules = new List<IOrderProcessingRule>();

            foreach (Product prod in order.Product)
                rules = _rulesRepo.GetRules(prod.ProductRules);

            // act
            List<RuleResult> actualRuleResult = _rulesRepo.RunRules(rules, order);

            // assert
            Assert.AreEqual(expectedRuleResult.Count, actualRuleResult.Count);
        }

        [TestMethod]
        public void TestOrderProcessForLearningToSkiVideo()
        {
            // arrange
            List<RuleResult> expectedRuleResult = new List<RuleResult>()
            {
                RuleResult.GetInstance("VIDLEARNTOSKI", "Generated packing slip for shipping."),
                RuleResult.GetInstance("VIDLEARNTOSKI", "Generated commission payment to the agent."),
                RuleResult.GetInstance("VIDLEARNTOSKI", "Added free 'First Aid' video to the packing slip.")
            };

            Order order = new Order()
            {
                Product = new List<Product>() { new Product() { ProductRules = new List<string>() { "VIDLEARNTOSKI" } } }
            };

            List<IOrderProcessingRule> rules = new List<IOrderProcessingRule>();

            foreach (Product prod in order.Product)
                rules = _rulesRepo.GetRules(prod.ProductRules);

            // act
            List<RuleResult> actualRuleResult = _rulesRepo.RunRules(rules, order);

            // assert
            Assert.AreEqual(expectedRuleResult.Count, actualRuleResult.Count);
        }

        [TestMethod]
        public void TestOrderProcessForMembershipActivtion()
        {
            // arrange
            List<RuleResult> expectedRuleResult = new List<RuleResult>()
            {
                RuleResult.GetInstance("MEM_ACT", "Membership activated."),
                RuleResult.GetInstance("MEM_ACT", "E-mailed owner of the activation/upgrade.")
            };

            Order order = new Order()
            {
                Product = new List<Product>() { new Product() { ProductRules = new List<string>() { "MEM_ACT" } } }
            };

            List<IOrderProcessingRule> rules = new List<IOrderProcessingRule>();

            foreach (Product prod in order.Product)
                rules = _rulesRepo.GetRules(prod.ProductRules);

            // act
            List<RuleResult> actualRuleResult = _rulesRepo.RunRules(rules, order);

            // assert
            Assert.AreEqual(expectedRuleResult.Count, actualRuleResult.Count);
        }

        [TestMethod]
        public void TestOrderProcessForMembershipUpgrade()
        {
            // arrange
            List<RuleResult> expectedRuleResult = new List<RuleResult>()
            {
                RuleResult.GetInstance("MEM_UPG", "Membership upgraded."),
                RuleResult.GetInstance("MEM_UPG", "E-mailed owner of the activation/upgrade.")
            };

            Order order = new Order()
            {
                Product = new List<Product>() { new Product() { ProductRules = new List<string>() { "MEM_UPG" } } }
            };

            List<IOrderProcessingRule> rules = new List<IOrderProcessingRule>();

            foreach (Product prod in order.Product)
                rules = _rulesRepo.GetRules(prod.ProductRules);

            // act
            List<RuleResult> actualRuleResult = _rulesRepo.RunRules(rules, order);

            // assert
            Assert.AreEqual(expectedRuleResult.Count, actualRuleResult.Count);
        }
    }
}
