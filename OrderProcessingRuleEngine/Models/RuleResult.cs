namespace OrderProcessingRuleEngine.Models
{
    public class RuleResult
    {
        public string RuleName { get; set; }
        public string RuleOutcome { get; set; }

        private RuleResult(string ruleName, string ruleOutCome)
        {
            RuleName = ruleName;
            RuleOutcome = ruleOutCome;
        }

        public static RuleResult GetInstance(string ruleName, string ruleOutCome)
        {
            return new RuleResult(ruleName, ruleOutCome);
        }
    }
}
