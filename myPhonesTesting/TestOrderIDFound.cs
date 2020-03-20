using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace myPhonesTesting
{
    [TestClass]
    public class TestOrderIDFound
    {
        public object OrderId { get; private set; }

        [TestMethod]

        public void TestMethod1()
        {
            clsOrder OrderTest = new clsOrder();
            Boolean Found = false;
            Int32 OrderId = 1;
            Boolean OK = true;
            Found = OrderTest.Find(OrderId);
            if (OrderTest.OrderID != 1)
            
            {
                OK = false;
            }

            Assert.IsTrue(OK);

        }
    }
}
