using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RulesEngine.Domain;

namespace RulesEngine.Sample.Rules
{
    public class OverMinimumIdealRangeRule : RuleBase
    {
        Unit self;
        Unit target;

        public OverMinimumIdealRangeRule(Unit self, Unit target)
        {
            this.FailureMessage = "Target inside of minimum ideal range";
            this.self = self;
            this.target = target;
        }

        public override bool Validate()
        {
            bool success = false;

            double aSquared = Math.Pow(Math.Abs(self.XCoordinate - target.XCoordinate), 2);
            double bSquared = Math.Pow(Math.Abs(self.YCoordinate - target.YCoordinate), 2);

            if (Math.Sqrt(aSquared + bSquared) > self.MinimumIdealRange)
                success = true;

            return success;
        }
    }
}