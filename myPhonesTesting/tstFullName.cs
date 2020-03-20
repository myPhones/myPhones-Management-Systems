using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace myPhonesTesting
{
    [TestClass]
    public class tstFullName
    {
        [TestMethod]
        public void TestMethod1()
        {
            clsFullName AnFullName = new clsFullName();
            Assert.IsNotNull(AnFullName);
        }
    }
}
