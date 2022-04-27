using Microsoft.VisualStudio.TestTools.UnitTesting;
using Genesys_v2;
using System;
using System.Collections.Generic;
using System.Text;

namespace Genesys_v2.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void StringGeneratorTest()
        {
            var number = "2";

            var expected = new List<string> { "a", "b", "c" };
            var actualResults = Program.StringGenerator(number);
            CollectionAssert.AreEqual(expected, actualResults);
        }
    }
}