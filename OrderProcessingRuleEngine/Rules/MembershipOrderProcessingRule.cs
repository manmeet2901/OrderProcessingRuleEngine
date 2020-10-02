using System.Collections.Generic;
using OrderProcessingRuleEngine.Models;

namespace OrderProcessingRuleEngine.Rules
{
    public abstract class MembershipOrderProcessingRule : IOrderProcessingRule
    {
        public abstract string RuleName { get; set; }

        private string ActivateMembership()
        {
            return "Membership activated";
        }

        protected string EmailOwner()
        {
            return "E-mailed owner of the activation/upgrade";
        }

        public virtual List<RuleResult> Process(Order order)
        {
            ActivateMembership();

            EmailOwner();

            throw new System.NotImplementedException();
        }
    }
}
