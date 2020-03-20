using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace myPhonesTesting
{
    [TestClass]
    public class StaffJobTitle
    {
        [TestMethod]
        public void TestMethod1()
        {
            clsStaff staffTesting = new clsStaff();
            Boolean Found = false;
            Boolean Ok = true;
            string staffJobTitle = "admin";
            Found = staffTesting.Find(staffJobTitle);
            if (staffTesting.staffJobTitle != "admin")
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }
    }
}
