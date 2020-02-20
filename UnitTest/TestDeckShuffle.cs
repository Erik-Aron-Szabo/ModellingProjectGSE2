using NUnit.Framework;
using ModellingProjectGSE2;
using System.Collections.Generic;
using System;

namespace UnitTest
{
    [TestFixture]
    public class TestDeckShuffle
    {
        [TestCase]
        public void TestShuffle()
        {
            Read reader = new ModellingProjectGSE2.Read();
            List<Card> cardList1;
            cardList1 = reader.LoadFromXMLParts();
            List<Card> cardList2;
            cardList2 = reader.LoadFromXMLParts();
            Utility util = new Utility();
            util.Shuffle(cardList2);

            Assert.AreNotEqual(cardList1, cardList2);
        }


    }
}
