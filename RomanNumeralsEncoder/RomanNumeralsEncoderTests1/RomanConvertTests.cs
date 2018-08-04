using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumeralsEncoder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RomanNumeralsEncoder.Tests
{
    [TestClass()]
    public class RomanConvertTests
    {
        [TestMethod()]
        public void SolutionTest()
        {
            var expected = "I";
            var actural = 1;
            Assert.AreEqual(expected, RomanConvert.Solution(actural));
        }
        [TestMethod()]
        public void SolutionTest2()
        {
            var expected = "II";
            var actural = 2;
            Assert.AreEqual(expected, RomanConvert.Solution(actural));
        }
        [TestMethod()]
        public void SolutionTest3()
        {
            var expected = "IV";
            var actural = 4;
            Assert.AreEqual(expected, RomanConvert.Solution(actural));
        }
        [TestMethod()]
        public void SolutionTest4()
        {
            var expected = "D";
            var actural = 500;
            Assert.AreEqual(expected, RomanConvert.Solution(actural));
        }
        [TestMethod()]
        public void SolutionTest5()
        {
            var expected = "M";
            var actural = 1000;
            Assert.AreEqual(expected, RomanConvert.Solution(actural));
        }
        [TestMethod()]
        public void SolutionTest6()
        {
            var expected = "MCMLIV";
            var actural = 1954;
            Assert.AreEqual(expected, RomanConvert.Solution(actural));
        }
        [TestMethod()]
        public void SolutionTest7()
        {
            var expected = "MCMXC";
            var actural = 1990;
            Assert.AreEqual(expected, RomanConvert.Solution(actural));
        }
        [TestMethod()]
        public void SolutionTest8()
        {
            var expected = "MMVIII";
            var actural = 2008;
            Assert.AreEqual(expected, RomanConvert.Solution(actural));
        }
        [TestMethod()]
        public void SolutionTest9()
        {
            var expected = "MMXIV";
            var actural = 2014;
            Assert.AreEqual(expected, RomanConvert.Solution(actural));
        }
        [TestMethod()]
        public void SolutionTest10()
        {
            var expected = "MCCCXCI";
            var actural = 1391;
            Assert.AreEqual(expected, RomanConvert.Solution(actural));
        }
    }
}