using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace myPhonesTesting
{
    [TestClass]
    public class tstPrice
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsPrice AnPrice = new clsPrice();
            Assert.IsNotNull(AnPrice);
        }
    }
}
