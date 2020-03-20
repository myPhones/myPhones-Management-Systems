using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace myPhonesTesting
{
    [TestClass]
    public class StaffIDFound
    {
        [TestMethod]
        public void TestMethod1()
        {
            clsStaff staffTesting = new clsStaff();
            Boolean Found = false;
            Boolean Ok = true;
            Int32 staffId = 1;
            Found = staffTesting.Find(staffId);
            if (staffTesting.staffId != 1)
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }
    }
}
