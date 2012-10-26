using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using RulesEngine.Sample;
using RulesEngine.Sample.Rules;
using RulesEngine.Domain;

namespace RulesEngine.UnitTests.Sample
{
    [TestFixture]
    public class UnderMaxRangeTests
    {

        [Test]
        public void PassMaxRangeTest()
        {
            //Assemble
            Unit unit1 = new Unit() { MaximumRange = 10, XCoordinate = 0, YCoordinate = 0 };
            Unit unit2 = new Unit() { MaximumRange = 10, XCoordinate = 0, YCoordinate = 5 };

            RuleSet rules = new RuleSet();
            rules.Add(new UnderMaximumRangeRule(unit1, unit2));

            //Act
            bool success = rules.Validate();


            //Assert
            Assert.IsTrue(success, "Unit should be inside of max range");
        }

        [Test]
        public void FailMaxRangeTest()
        {
            //Assemble
            Unit unit1 = new Unit() { MaximumRange = 10, XCoordinate = 0, YCoordinate = 0 };
            Unit unit2 = new Unit() { MaximumRange = 10, XCoordinate = 0, YCoordinate = 500 };

            RuleSet rules = new RuleSet();
            rules.Add(new UnderMaximumRangeRule(unit1, unit2));

            //Act
            bool success = rules.Validate();

            //Assert
            Assert.IsFalse(success, "Unit should be outside of max range");
        }
    }
}
