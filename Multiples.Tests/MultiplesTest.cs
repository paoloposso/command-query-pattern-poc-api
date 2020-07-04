using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Multiples.Domain.Services;

namespace Multiples.Tests
{
    [TestClass]
    public class MultiplesTest
    {
        MultiplesCheckerService _multiplesCheckerService;

        public MultiplesTest()
        {
            //injection
            _multiplesCheckerService = new MultiplesCheckerService();
        }

        [TestMethod]
        public void ShouldReturnTrueForAll()
        {
            var input = new List<string> {
                "55", "22", "44"
            };

            var list = _multiplesCheckerService.CheckMultiples(input);

            Assert.AreEqual(list.Count, input.Count);
            Assert.AreEqual(list.Count, list.Where(p => p.IsMultiple == true).ToList().Count);
        }

        [TestMethod]
        public void ShouldReturnTrueForOnlyOne()
        {
            var input = new List<string> {
                "42", "43", "44"
            };

            var list = _multiplesCheckerService.CheckMultiples(input);

            Assert.AreEqual(list.Count, input.Count);
            Assert.AreEqual(1, list.Where(p => p.IsMultiple == true).ToList().Count);
        }

        [TestMethod]
        public void ShouldReturnTrue()
        {
            var input = new List<string> {
                "94186576"
            };

            var list = _multiplesCheckerService.CheckMultiples(input);

            Assert.AreEqual(list.Count, input.Count);
            Assert.AreEqual(1, list.Where(p => p.IsMultiple == true).ToList().Count);
        }

        [TestMethod]
        public void ShouldReturnFalse()
        {
            var input = new List<string> {
                "122"
            };

            var list = _multiplesCheckerService.CheckMultiples(input);

            Assert.AreEqual(list.Count, input.Count);
            Assert.AreEqual(0, list.Where(p => p.IsMultiple == true).ToList().Count);
        }
    }
}
