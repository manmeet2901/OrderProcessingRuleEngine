using System.Collections.Generic;
using OrderProcessingRuleEngine.Models;

namespace OrderProcessingRuleEngine.Rules
{
    public class MembershipOrderProcessingRule : IOrderProcessingRule
    {
        public string RuleName { get; set; }

        public MembershipOrderProcessingRule(string ruleName)
        {
            RuleName = ruleName;
        }

        private string ActivateMembership()
        {
            return "Membership activated.";
        }

        protected string EmailOwner()
        {
            return "E-mailed owner of the activation/upgrade.";
        }

        public virtual List<RuleResult> Process(Order order)
        {
            return new List<RuleResult>
            {
                RuleResult.GetInstance(RuleName, ActivateMembership()),
                RuleResult.GetInstance(RuleName, EmailOwner())
            };
        }
    }
}
