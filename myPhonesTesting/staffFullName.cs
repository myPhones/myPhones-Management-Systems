using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace myPhonesTesting
{
    [TestClass]
    public class staffFullName
    {
        public void StaffFullName()
        {
            clsStaff AnStaff = new clsStaff();
            string TestData = "vishal soma";
           // AnStaff.staffFullName = TestData;
            Assert.AreEqual(AnStaff.staffFullName, TestData);
        }

    }
}