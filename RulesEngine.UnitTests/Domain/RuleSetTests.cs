using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using RulesEngine.Domain;

namespace RulesEngine.UnitTests.Domain
{
    [TestFixture]
    public class RuleSetTests
    {
        [Test]
        public void RuleSetSuccess()
        {
            //Assemble
            RuleSet rules = new RuleSet();
            rules.Add(new StringMatchRule(){ string1 = "One", string2 = "One" });

            //Act
            bool success = rules.Validate();

            //Assert
            Assert.IsTrue(success, "Strings did not match");
            Assert.IsEmpty(rules.FailureMessages, "There should not be any FailureMessages");

        }

        [Test]
        public void RuleSetFailure()
        {
            //Assemble
            RuleSet rules = new RuleSet();
            rules.Add(new StringMatchRule() { string1 = "Two", string2 = "Hats" });

            //Act
            bool success = rules.Validate();

            //Assert
            Assert.IsFalse(success, "No match should exist");
            Assert.IsNotEmpty(rules.FailureMessages, "There should not be any FailureMessages");

        }

    }


    public class StringMatchRule : RuleBase
    {
        public string string1;
        public string string2;


        public override bool Validate()
        {
            return string1 == string2;
        }

    }
}
