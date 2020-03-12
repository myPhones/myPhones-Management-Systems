using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace myPhonesTesting
{
    [TestClass]
    public class TestStaffNoFound
    {
        [TestMethod]
        public void TestMethod1()
        {
            clsStaff staffTesting = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 staffId = 13;
            Found = staffTesting.Find(staffId);
            if (staffTesting.staffId != 13) 
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }
    }
}
