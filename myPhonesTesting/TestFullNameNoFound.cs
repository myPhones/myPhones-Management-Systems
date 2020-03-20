using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace myPhonesTesting
{
    [TestClass]
    public class TestFullNameNoFound
    {
        [TestMethod]
        public void TestMethod1()
        {
            clsStaff staffTesting = new clsStaff();
            Boolean Found = false;
            Boolean Ok = true;
            string staffFullName = "vishal soma";
            Found = staffTesting.Find(staffFullName);
            if (staffTesting.staffFullName != "vishal soma")
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);

        }
    }
}
