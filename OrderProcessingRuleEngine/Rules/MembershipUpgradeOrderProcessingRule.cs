﻿using OrderProcessingRuleEngine.Models;
using System.Collections.Generic;

namespace OrderProcessingRuleEngine.Rules
{
    public class MembershipUpgradeOrderProcessingRule : MembershipOrderProcessingRule
    {
        private string UpgradeMembership()
        {
            return "Membership upgraded";
        }

        public override List<RuleResult> Process(Order order)
        {
            UpgradeMembership();

            EmailOwner();

            throw new System.NotImplementedException();
        }
    }
}
