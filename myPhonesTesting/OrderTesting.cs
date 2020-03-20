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
        public void OrderID()
        {
            clsOrder OrderTest = new clsOrder();
            Int32 TestData = 1;
            OrderTest.OrderID = 1;
            Assert.AreEqual(OrderTest.OrderID, TestData);
        }


        public void OrderLineID()
        {
            clsOrder OrderTest = new clsOrder();
            Int32 TestData = 1;
            OrderTest.OrderLineID = 1;
            Assert.AreEqual(OrderTest.OrderLineID, TestData);
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

        
    }

}