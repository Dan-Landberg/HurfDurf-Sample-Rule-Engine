﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using RulesEngine.Sample;
using RulesEngine.Domain;
using RulesEngine.Sample.Rules;

namespace RulesEngine.UnitTests.Sample
{
    [TestFixture]
    public class OverMinimumIdealRangeRuleTests
    {
        [Test]
        public void PassMinIdealRangeTest()
        {
            //Assemble
            Unit unit1 = new Unit() { MinimumIdealRange = 1, XCoordinate = 0, YCoordinate = 0 };
            Unit unit2 = new Unit() { MinimumIdealRange = 1, XCoordinate = 0, YCoordinate = 5 };

            RuleSet rules = new RuleSet();
            rules.Add(new OverMinimumIdealRangeRule(unit1, unit2));

            //Act
            bool success = rules.Validate();


            //Assert
            Assert.IsTrue(success, "Unit should be outside of min ideal range");
        }

        [Test]
        public void FailMinIdealRangeTest()
        {
            //Assemble
            Unit unit1 = new Unit() { MinimumIdealRange = 10, XCoordinate = 0, YCoordinate = 0 };
            Unit unit2 = new Unit() { MinimumIdealRange = 10, XCoordinate = 0, YCoordinate = 5 };

            RuleSet rules = new RuleSet();
            rules.Add(new OverMinimumIdealRangeRule(unit1, unit2));

            //Act
            bool success = rules.Validate();

            //Assert
            Assert.IsFalse(success, "Unit should be inside of min ideal range");
        }

    }
}
