using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace myPhonesTesting
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]

        public void InstanceOK()
        {
            clsCustomer anCustomer = new clsCustomer();
            // test to see that is exists//
            Assert.IsNotNull(anCustomer);
        }
        public void TestMethod1()
        {

        }
    }
}
