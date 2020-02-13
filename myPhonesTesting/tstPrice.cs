using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace myPhonesTesting
{
    [TestClass]
    public class tstPrice
    {
        [TestMethod]
        public void TestPrice()
        {

            clsPrice AnPrice = new clsPrice();

            Assert.IsNotNull(AnPrice);
        }
    }
    }
