using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace myPhonesTesting
{
    [TestClass]
    public class StaffAdminRightsFound
    {
        [TestMethod]
        public void TestMethod1()
        {
            clsStaff staffTesting = new clsStaff();
            Boolean Found = false;
            Boolean Ok = true;
            Int32 staffAdminRights = 1;
            Found = staffTesting.Find(staffAdminRights);
            if (staffTesting.staffAdminRights != true)
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }
    }
}
