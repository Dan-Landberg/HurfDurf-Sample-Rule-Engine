using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RulesEngine.Domain
{

    /// <summary>
    /// A collection of rules representing all of the the conditions that must be met for a single event
    /// </summary>
    public class RuleSet : List<RuleBase>
    {
        public List<string> FailureMessages { get; set; }

        public RuleSet()
        {
            this.FailureMessages = new List<string>();
        }

        /// <summary>
        /// Validates all of the rules in the given ruleset.
        /// Failure messages are written to FailureMessages, which is truncated every time validation is run.
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {          
            bool success = true;

            //Clear out any old failure messages
            this.FailureMessages.Clear();

            //Loop through all of the rules.  For any that fail, mark the whole ruleset as failed, and add it's message to the collection of failure messages
            foreach (RuleBase rule in this)
            {
                if (!rule.Validate())
                {
                    success = false;
                    FailureMessages.Add(rule.FailureMessage);
                }
            }

            return success;
        }
    }
}
