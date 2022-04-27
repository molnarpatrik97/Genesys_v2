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
        public void LetterGeneratorTest()
        {
            var number = "2";

            var expectedResult = new List<string>{"a","b","c" };
            var result = Program.LetterGenerator(number);
        }
        [TestMethod()]
        public void LetterGeneratorTest2()
        {
            var number = "24";
            var expectedResult = new List<string> { "ag", "ah", "ai", "bg", "bh", "bi", "cg", "ch", "ci" };
            var result = Program.LetterGenerator(number);
        }
    }
}