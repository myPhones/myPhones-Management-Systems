using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace myPhonesTesting
{
    [TestClass]
    public class OrderTesting
    {
        [TestMethod]
        public void DateAddedOrderOK()
        {
            clsOrder OrderTest = new clsOrder();
            DateTime TestData = DateTime.Now.Date;
            OrderTest.DateAdded = TestData;
            Assert.AreEqual(OrderTest.DateAdded, TestData);
        }

        [TestMethod]

        public void TimeAddedOrderOK()
        {
            clsOrder OrderTest = new clsOrder();
            DateTime TestData = DateTime.Now;
            OrderTest.TimeAdded = TestData;
            Assert.AreEqual(OrderTest.TimeAdded, TestData);
        }
        public void ShippedAddedOrderOK()
        {
            clsOrder OrderTest = new clsOrder();
           Boolean TestData = true;
            OrderTest.ShippedAdded = TestData;
            Assert.AreEqual(OrderTest.ShippedAdded, TestData);
        }

        public void PriceAddedOrderOK()
        {
            clsOrder OrderTest = new clsOrder();
            Decimal TestData = 1;
            OrderTest.PriceAdded = TestData;
            Assert.AreEqual(OrderTest.PriceAdded, TestData);
        }
    }

}