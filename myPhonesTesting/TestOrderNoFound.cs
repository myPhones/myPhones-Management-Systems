﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace myPhonesTesting
{
    [TestClass]
    public class TestOrderNoFound
    {
        public bool OK { get; private set; }

        [TestMethod]
        public void testOrderNoFound()
        {
            clsOrder OrderTest = new clsOrder();
            Boolean Found = false;
            Int32 OrderID = 1;
            Boolean OK = true;
            Found = OrderTest.Find(OrderID);
            if (OrderTest.OrderLineID != 1)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
     
        }
    }
}
