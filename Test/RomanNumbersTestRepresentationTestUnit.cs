using Microsoft.VisualStudio.TestTools.UnitTesting;
using Code;
using System;

namespace Test
{
    [TestClass]
    public class RomanNumbersTestRepresentationTestUnit
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("I", new RomanNumbersTestRepresentation().of(1));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual("II", new RomanNumbersTestRepresentation().of(2));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual("III", new RomanNumbersTestRepresentation().of(3));
        }

        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual("IV", new RomanNumbersTestRepresentation().of(4));
        }

        [TestMethod]
        public void TestMethod5()
        {
            Assert.AreEqual("V", new RomanNumbersTestRepresentation().of(5));
        }

        [TestMethod]
        public void TestMethod6()
        {
            Assert.AreEqual("VI", new RomanNumbersTestRepresentation().of(6));
        }

        [TestMethod]
        public void TestMethod7()
        {
            Assert.AreEqual("VII", new RomanNumbersTestRepresentation().of(7));
        }

        [TestMethod]
        public void TestMethod8()
        {
            Assert.AreEqual("VIII", new RomanNumbersTestRepresentation().of(8));
        }

        [TestMethod]
        public void TestMethod9()
        {
            Assert.AreEqual("IX", new RomanNumbersTestRepresentation().of(9));
        }

        [TestMethod]
        public void TestMethod10()
        {
            Assert.AreEqual("X", new RomanNumbersTestRepresentation().of(10));
        }

        [TestMethod]
        public void TestMethod11()
        {
            Assert.AreEqual("XI", new RomanNumbersTestRepresentation().of(11));
        }

        [TestMethod]
        public void TestMethod12()
        {
            Assert.AreEqual("XII", new RomanNumbersTestRepresentation().of(12));
        }

        [TestMethod]
        public void TestMethod13()
        {
            Assert.AreEqual("XIII", new RomanNumbersTestRepresentation().of(13));
        }

        [TestMethod]
        public void TestMethod14()
        {
            Assert.AreEqual("XIV", new RomanNumbersTestRepresentation().of(14));
        }

        [TestMethod]
        public void TestMethod15To18()
        {
            Assert.AreEqual("XV", new RomanNumbersTestRepresentation().of(15));
            Assert.AreEqual("XVI", new RomanNumbersTestRepresentation().of(16));
            Assert.AreEqual("XVII", new RomanNumbersTestRepresentation().of(17));
            Assert.AreEqual("XVIII", new RomanNumbersTestRepresentation().of(18));
        }

        [TestMethod]
        public void TestMethod19()
        {
            Assert.AreEqual("XIX", new RomanNumbersTestRepresentation().of(19));
        }

        [TestMethod]
        public void TestMethod20To29()
        {
            Assert.AreEqual("XX", new RomanNumbersTestRepresentation().of(20));
            Assert.AreEqual("XXI", new RomanNumbersTestRepresentation().of(21));
            Assert.AreEqual("XXII", new RomanNumbersTestRepresentation().of(22));
            Assert.AreEqual("XXIV", new RomanNumbersTestRepresentation().of(24));
            Assert.AreEqual("XXIX", new RomanNumbersTestRepresentation().of(29));
        }

        [TestMethod]
        public void TestMethod30To39()
        {
            Assert.AreEqual("XXX", new RomanNumbersTestRepresentation().of(30));
            Assert.AreEqual("XXXI", new RomanNumbersTestRepresentation().of(31));
            Assert.AreEqual("XXXII", new RomanNumbersTestRepresentation().of(32));
            Assert.AreEqual("XXXIV", new RomanNumbersTestRepresentation().of(34));
            Assert.AreEqual("XXXIX", new RomanNumbersTestRepresentation().of(39));
        }

        [TestMethod]
        public void TestMethod40To49()
        {
            Assert.AreEqual("XL", new RomanNumbersTestRepresentation().of(40));
            Assert.AreEqual("XLI", new RomanNumbersTestRepresentation().of(41));
            Assert.AreEqual("XLII", new RomanNumbersTestRepresentation().of(42));
            Assert.AreEqual("XLIV", new RomanNumbersTestRepresentation().of(44));
            Assert.AreEqual("XLIX", new RomanNumbersTestRepresentation().of(49));
        }

        [TestMethod]
        public void TestMethod50To89()
        {
            Assert.AreEqual("L", new RomanNumbersTestRepresentation().of(50));
            Assert.AreEqual("LIV", new RomanNumbersTestRepresentation().of(54));
            Assert.AreEqual("LXXVII", new RomanNumbersTestRepresentation().of(77));
            Assert.AreEqual("LXXVI", new RomanNumbersTestRepresentation().of(76));
            Assert.AreEqual("LXXXIX", new RomanNumbersTestRepresentation().of(89));
        }

        [TestMethod]
        public void TestMethod90To99()
        {
            Assert.AreEqual("XC", new RomanNumbersTestRepresentation().of(90));
            Assert.AreEqual("XCII", new RomanNumbersTestRepresentation().of(92));
            Assert.AreEqual("XCIV", new RomanNumbersTestRepresentation().of(94));
            Assert.AreEqual("XCV", new RomanNumbersTestRepresentation().of(95));
            Assert.AreEqual("XCIX", new RomanNumbersTestRepresentation().of(99));
        }

        [TestMethod]
        public void TestMethod100To999()
        {
            Assert.AreEqual("C", new RomanNumbersTestRepresentation().of(100));
            Assert.AreEqual("CCC", new RomanNumbersTestRepresentation().of(300));
            Assert.AreEqual("D", new RomanNumbersTestRepresentation().of(500));
            Assert.AreEqual("DCCCL", new RomanNumbersTestRepresentation().of(850));
            Assert.AreEqual("CMXCIX", new RomanNumbersTestRepresentation().of(999));
        }

        [TestMethod]
        public void TestMethod1000To9990()
        {
            Assert.AreEqual("M", new RomanNumbersTestRepresentation().of(1000));
            Assert.AreEqual("V", new RomanNumbersTestRepresentation().of(5000));
            Assert.AreEqual("MXCMXCIX", new RomanNumbersTestRepresentation().of(9999));
        }

        [TestMethod]
        public void TestMethod0()
        {
            Exception ex = Assert.ThrowsException<Exception>(() => new RomanNumbersTestRepresentation().of(0));
            Assert.AreEqual(RomanNumbersTestRepresentation.ROMAN_NUMBER_HAS_NO_ZERO, ex.Message);
            
        }
    }
}
