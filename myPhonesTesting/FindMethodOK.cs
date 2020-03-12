using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace myPhonesTesting
{
    [TestClass]
    public class FindMethodOK
    {
        [TestMethod]
        public void TestMethod1()
        {
            clsStaff staffTest = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 staffId = 1;
            Found = staffTest.Find(staffId);
            Assert.IsTrue(Found);
        }
    }
}
