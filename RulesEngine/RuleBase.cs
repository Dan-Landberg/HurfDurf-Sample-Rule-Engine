using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RulesEngine.Domain
{
    /// <summary>
    /// The base class from which all rules must inherit
    /// </summary>
    public abstract class RuleBase
    {
        /// <summary>
        /// The message that should be used in the event of a failure
        /// </summary>
        public string FailureMessage { get; protected set; }

        /// <summary>
        /// The method which indicates whether success or failure conditions were met.
        /// </summary>
        /// <returns></returns>
        public abstract bool Validate();
    }
}
