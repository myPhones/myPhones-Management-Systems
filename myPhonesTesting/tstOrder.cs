using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace myPhonesTesting
{
    [TestClass]
    public class tstOrder
    {
        [TestMethod]
        public void TestOrder()
        {
            clsOrder AnOrder = new clsOrder();

            Assert.IsNotNull(AnOrder);
        }
    }
}
