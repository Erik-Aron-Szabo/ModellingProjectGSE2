using NUnit.Framework;
using ModellingProjectGSE2;
using System.Collections.Generic;

namespace UnitTest
{
    [TestFixture]
    public class TestCardCompare
    {
        [SetUp]
        public void Setup()
        {
           
            
        }

        [TestCase]
        public void TestWeight()
        {
            
            Card a = new Card("a", 8, 8, 8);
            Card b = new Card("b", 1, 10, 8);
            Assert.AreNotEqual(a._weight, b._weight);
        }
        [TestCase]
        public void TestPushup()
        {
           
            Card a = new Card("a", 8, 8, 8);
            Card b = new Card("b", 1, 10, 8);
            Assert.AreNotEqual(a._pushup, b._pushup);
        }
        [TestCase]
        public void TestShot()
        {
            
            Card a = new Card("a", 8, 8, 8);
            Card b = new Card("b", 1, 10, 8);
            Assert.AreEqual(a._nmrOfShots, b._nmrOfShots);
        }
    }
}