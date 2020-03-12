using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace myPhonesTesting
{
    [TestClass]
    public class stafftesting
    {
        [TestMethod]
        public void staffID()
        {
            clsStaff staffTest = new clsStaff();
            Int16 TestData = 1;
            staffTest.staffId = 1;
            Assert.AreEqual(staffTest.staffId, TestData);
        }

        [TestMethod]
        public void OrderId()
        {
            clsStaff staffTest = new clsStaff();
            Int16 TestData = 1;
            staffTest.orderId = 1;
            Assert.AreEqual(staffTest.orderId, TestData);
        }
        [TestMethod]
        public void staffFulName()
            {
                clsStaff staffTest = new clsStaff();
                string TestData = "vishal soma";
                staffTest.staffFullName = TestData;
                Assert.AreEqual(staffTest.staffFullName, TestData);
            }
       
        [TestMethod]
        public void staffJoined()
            {
                clsStaff staffTest = new clsStaff();
                DateTime TestData = DateTime.Now.Date;
                staffTest.staffJoined = TestData;
                Assert.AreEqual(staffTest.staffJoined, TestData);
            }

        [TestMethod]
        public void staffAdress()
        {
            clsStaff staffTest = new clsStaff();
            string TestData = "purey road, leicester";
            staffTest.staffAddress = TestData;
            Assert.AreEqual(staffTest.staffAddress, TestData);
        }

        [TestMethod]
        public void staffJobTitle()
        {
            clsStaff staffTest = new clsStaff();
            string TestData = "Admin";
            staffTest.staffJobTitle = TestData;
            Assert.AreEqual(staffTest.staffJobTitle, TestData);
        }

        [TestMethod]
        public void staffAdminRights()
        {
            clsStaff staffTest = new clsStaff();
            Boolean TestData = true;
            staffTest.staffAdminRights = TestData;
            Assert.AreEqual(staffTest.staffAdminRights, TestData);
        }

    }
}
