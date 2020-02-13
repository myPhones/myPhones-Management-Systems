using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace myPhonesTesting
{
    [TestClass]
    public class tstPhoneNumber
    {
        [TestMethod]
        public void TestMethod1()
        {
            clsPhoneNumber AnPhoneNumber = new clsPhoneNumber();
            Assert.IsNotNull(AnPhoneNumber);
        }
    }
}
