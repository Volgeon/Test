using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace testDemoTDD
{
    [TestClass]
    public class testBruch
    {
        [TestMethod]
        public void testQuotient1()
        {
            Bruch b1 = new Bruch(1,2);
            Assert.AreEqual(0.5, b1.quotient());
        }
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void testQuotient2()
        {
            Bruch b1 = new Bruch(1, 0);
            b1.quotient();
        }
        [TestMethod]
        public void testKuerzel()
        {
            Bruch b1 = new Bruch(2, 4);
            b1.kuerzel();
        }
    }
}
