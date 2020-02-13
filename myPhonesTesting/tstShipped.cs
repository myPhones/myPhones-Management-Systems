using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace myPhonesTesting
{
    [TestClass]
    public class tstShipped
    {
        [TestMethod]
        public void TestShipped()

        {

            clsShipped AnShipped = new clsShipped();

            Assert.IsNotNull(AnShipped);
        }
    }
    }

