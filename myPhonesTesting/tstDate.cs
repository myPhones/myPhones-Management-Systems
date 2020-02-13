using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace myPhonesTesting
{
    [TestClass]
    public class tstDate
    {
        [TestMethod]
        public void TestDate()
        {
            clsDate Andate = new clsDate();

            Assert.IsNotNull(Andate);
        }
    }
    }

