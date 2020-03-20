using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace myPhonesTesting
{
    [TestClass]
    public class OrderIDFound
    {
        [TestMethod]
        public void TestMethod1()
        {
            clsStaff staffTesting = new clsStaff();
            Boolean Found = false;
            Boolean Ok = true;
            Int32 orderId = 1;
            Found = staffTesting.Find(orderId);
            if (staffTesting.orderId != 1)
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }
    }
}
