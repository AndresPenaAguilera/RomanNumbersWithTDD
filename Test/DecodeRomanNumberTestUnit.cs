using Code;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    [TestClass]
    public  class DecodeRomanNumberTestUnit
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(1, DecodeRomanNumber.of("I"));
        }

        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual(4, DecodeRomanNumber.of("IV"));
        }

        [TestMethod]
        public void TestMethod5()
        {
            Assert.AreEqual(5, DecodeRomanNumber.of("V"));
        }

        [TestMethod]
        public void TestMethod21()
        {
            Assert.AreEqual(21, DecodeRomanNumber.of("XXI"));
        }

        [TestMethod]
        public void TestMethod90To99()
        {
            Assert.AreEqual(90,  DecodeRomanNumber.of("XC"));
            Assert.AreEqual(92,  DecodeRomanNumber.of("XCII"));
            Assert.AreEqual(94,  DecodeRomanNumber.of("XCIV"));
            Assert.AreEqual(95,  DecodeRomanNumber.of("XCV"));
            Assert.AreEqual(99,  DecodeRomanNumber.of("XCIX"));
        }

        [TestMethod]
        public void TestMethod1000To9990()
        {
            Assert.AreEqual(1000, DecodeRomanNumber.of("M"));
            //Assert.AreEqual(5000, new DecodeRomanNumber().of("V"));
            //Assert.AreEqual(9999, new DecodeRomanNumber().of("MXCMXCIX"));
        }
    }
}
