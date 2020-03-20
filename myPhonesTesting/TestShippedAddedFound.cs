using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace myPhonesTesting
{
    [TestClass]
    public class TestShippedAddedFound
    {
        [TestMethod]
        public void TestMethod1()
        {
            clsOrder OrderTest = new clsOrder();
            Boolean Found = false;
            Int32 OrderID = 1;
            Boolean OK = true;
            Found = OrderTest.Find(OrderID);

            if (OrderTest.ShippedAdded != true)
            {
                OK = false;

            }
            Assert.IsTrue(OK);
        }

    }
}
