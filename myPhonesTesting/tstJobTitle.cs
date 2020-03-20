using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace myPhonesTesting
{
    [TestClass]
    public class tstJobTitle
    {
        [TestMethod]
        public void TestMethod1()

        {
            clsJobTitle AnJobTitle = new clsJobTitle();
            Assert.IsNotNull(AnJobTitle);
        }
    }
}
