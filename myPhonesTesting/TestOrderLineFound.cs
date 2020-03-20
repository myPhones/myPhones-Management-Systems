using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace myPhonesTesting
{
    [TestClass]
    public class TestOrderLineFound
    {
        [TestMethod]
        public void TestMethod1()
        {
            clsOrder OrderTest = new clsOrder();
            Boolean Found = false;
            Int32 OrderLineID = 1;
            Boolean OK = true;
            Found = OrderTest.Find(OrderLineID);
            if (OrderTest.OrderLineID != 1)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }
    }
}
