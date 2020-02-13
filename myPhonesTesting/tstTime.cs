using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace myPhonesTesting
{
    [TestClass]
    public class tstTime
    {
        [TestMethod]
        public void TestTime()
        {
            clsTime AnTime = new clsTime();

            Assert.IsNotNull(AnTime);
        }

    }
}
