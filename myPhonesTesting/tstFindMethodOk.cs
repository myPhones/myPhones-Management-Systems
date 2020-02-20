using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace myPhonesTesting
{
    [TestClass]
    public class tstFindMethodOk
    {
        [TestMethod]
        public void FindMethodOk()
        {
            clsOrder OrderTest = new clsOrder();
            Boolean Found = false;
            Int32 OrderID = 1;
            Found = OrderTest.Find(OrderID);
            Assert.IsTrue(Found);

        }
    }
}
