using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace myPhonesTesting
{
    [TestClass]
    public class tstAdminRights
    {
        [TestMethod]
        public void TestMethod1()
        {
            clsAdminRights AnAdminRights = new clsAdminRights();
            Assert.IsNotNull(AnAdminRights);
        }
    }
}
