using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace myPhonesTesting
{
    [TestClass]
    public class StaffJoinedFound
    {
        [TestMethod]
        public void TestMethod1()
        {
            clsStaff staffTest = new clsStaff();
            Boolean Found = false;
            Boolean Ok = true;
            string staffJoined = "purley road";
            Found = staffTest.Find(staffJoined);
            if 
                (staffTest.staffJoined != Convert.ToDateTime("20/02/2020"))
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }
    }
}
