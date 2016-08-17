using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq.Expressions;

namespace EnlightenMe.Tests.InfrastructureTest
{
    [TestClass]
    public class RuleConstructorTest
    {
        [TestMethod]
        public void IsConstructorWorking()
        {
            var desiredLeft = "1";
            var desiredOperator = "Add";
            var desiredRight = "2";
            var rule = new EnlightenMe.Infrastructure.Rule(desiredLeft, desiredOperator, desiredRight);
            Assert.IsTrue(rule.MemberName.Equals(desiredLeft));
            Assert.IsTrue(rule.Operator.Equals(desiredOperator));
            Assert.IsTrue(rule.DesiredValue.Equals(desiredRight));
        }
    }
}
