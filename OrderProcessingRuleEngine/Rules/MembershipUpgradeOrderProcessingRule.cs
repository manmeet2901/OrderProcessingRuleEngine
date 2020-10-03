using OrderProcessingRuleEngine.Models;
using System.Collections.Generic;

namespace OrderProcessingRuleEngine.Rules
{
    public class MembershipUpgradeOrderProcessingRule : MembershipOrderProcessingRule
    {
        public MembershipUpgradeOrderProcessingRule(string ruleName) : base(ruleName)
        {

        }

        private string UpgradeMembership()
        {
            return "Membership upgraded.";
        }

        public override List<RuleResult> Process(Order order)
        {
            return new List<RuleResult>
            {
               RuleResult.GetInstance(RuleName, UpgradeMembership()),
               RuleResult.GetInstance(RuleName, EmailOwner())
            };
        }
    }
}
