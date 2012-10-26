using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RulesEngine.Domain;
using RulesEngine.Sample.Rules;

namespace RulesEngine.Sample
{
    public class Unit
    {
        public string Name { get; set; }

        public double MinimumRange { get; set; }
        public double MaximumRange { get; set; }
        public double MinimumIdealRange { get; set; }
        public double MaximumIdealRange { get; set; }

        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }

        public string Fire(Unit target)
        {
            string result = string.Empty;

            RuleSet idealHitRules = new RuleSet();
            idealHitRules.Add(new UnderMaximumIdealRangeRule(this, target));
            idealHitRules.Add(new OverMinimumIdealRangeRule(this, target));
            
            RuleSet regularHitRules = new RuleSet();
            regularHitRules.Add(new UnderMaximumRangeRule(this, target));
            regularHitRules.Add(new OverMinimumRangeRule(this, target));

            //Fire!
            if (idealHitRules.Validate())
            {
                result = "Ideal hit!";
            }
            else if (regularHitRules.Validate())
            {
                result = "Hit.";
            }
            else
            {
                result = regularHitRules.FailureMessages[0];
            }

            return result;
        }
    }
}
