﻿using OrderProcessingRuleEngine.Models;
using System.Collections.Generic;

namespace OrderProcessingRuleEngine.Rules
{
    // rule for a book
    public class BookOrderProcessingRule : GoodsOrderProcessingRule
    {
        public override string RuleName { get; set; }

        protected string CreateDuplicatePackingSlipForRoyaltyDepartment()
        {
            return "Created duplicate packing slip for the royalty department.";
        }

        public override List<RuleResult> Process(Order order)
        {
            base.Process(order);

            CreateDuplicatePackingSlipForRoyaltyDepartment();

            throw new System.NotImplementedException();
        }
    }
}