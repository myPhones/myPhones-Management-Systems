using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace myPhonesTesting
{
    [TestClass]
    public class StaffAddressFound
    {
        [TestMethod]
        public void TestMethod1()
        {
            clsStaff staffTesting = new clsStaff();
            Boolean Found = false;
            Boolean Ok = true;
            string staffAddress = "purley road";
            Found = staffTesting.Find(staffAddress);
            if (staffTesting.staffAddress != "purley road")
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }
    }
}
