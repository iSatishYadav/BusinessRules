using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EnlightenMe.Infrastructure;

namespace EnlightenMe.Tests.InfrastructureTest
{
    [TestClass]
    public class RuleTest
    {
        public class Dummy
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public DateTime Date { get; set; }
        }

        [TestMethod]
        public void RuleMatch()
        {
            IRule rule = new Rule("Id", "GreaterThan", "5");
            IRuleEngine<Dummy> engine = new RuleEngine<Dummy>();
            var isMatch = engine.IsMatch(new Dummy () { Id =  10, Name =  "Dum", Date = DateTime.Now }, rule);
            Assert.IsTrue(isMatch);
        }
    }
}
