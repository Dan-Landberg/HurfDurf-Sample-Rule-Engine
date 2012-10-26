using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using RulesEngine.Sample;
using RulesEngine.Domain;
using RulesEngine.Sample.Rules;

namespace RulesEngine.UnitTests.Sample
{
    class UnderMaximumIdealRangeRuleTest
    {
        [Test]
        public void PassMaxIdealRangeTest()
        {
            //Assemble
            Unit unit1 = new Unit() { MaximumIdealRange = 10, XCoordinate = 0, YCoordinate = 0 };
            Unit unit2 = new Unit() { MaximumIdealRange = 10, XCoordinate = 0, YCoordinate = 5 };

            RuleSet rules = new RuleSet();
            rules.Add(new UnderMaximumIdealRangeRule(unit1, unit2));

            //Act
            bool success = rules.Validate();

            //Assert
            Assert.IsTrue(success, "Unit should be inside of max ideal range");
        }

        [Test]
        public void FailMaxIdealRangeTest()
        {
            //Assemble
            Unit unit1 = new Unit() { MaximumIdealRange = 10, XCoordinate = 0, YCoordinate = 0 };
            Unit unit2 = new Unit() { MaximumIdealRange = 10, XCoordinate = 0, YCoordinate = 500 };

            RuleSet rules = new RuleSet();
            rules.Add(new UnderMaximumIdealRangeRule(unit1, unit2));

            //Act
            bool success = rules.Validate();

            //Assert
            Assert.IsFalse(success, "Unit should be outside of max ideal range");
        }

    }
}
