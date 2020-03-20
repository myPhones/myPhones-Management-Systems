using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace myPhonesTesting
{
    [TestClass]
    public class PhoneTesting
    {
        [TestMethod]
        public void TestMethod1()
        {
            clsPhones AnPhones = new clsPhones();
            Boolean TestData = true;
            AnPhones.InStock = TestData;
            Assert.AreEqual(AnPhones.InStock, TestData);

        }
        [TestMethod]
        public void DatePhoneAddedOK()
        {
            clsPhones AnPhones = new clsPhones();
            DateTime TestData = DateTime.Now.Date;
            AnPhones.DatePhoneAdded = TestData;
            Assert.AreEqual(AnPhones.DatePhoneAdded, TestData);
        }

        [TestMethod]
        public void PriceOK()
        {
            clsPhones AnPhones = new clsPhones();
            Decimal TestData = 1;
            AnPhones.Price = 1;
            Assert.AreEqual(AnPhones.Price, TestData);

        }
        [TestMethod]
        public void InStockOK()
        {
            clsPhones AnPhones = new clsPhones();
            Boolean TestData = true;
            AnPhones.InStock = TestData;
            Assert.AreEqual(AnPhones.InStock, TestData);
        }
        [TestMethod]
        public void PhoneMakeOK()
        {
            clsPhones AnPhones = new clsPhones();
            string TestData = "Iphone";
            AnPhones.PhoneMake = TestData;
            Assert.AreEqual(AnPhones.PhoneMake, TestData);
        }
        [TestMethod]
        public void PhoneModelOK()
        {
            clsPhones AnPhones = new clsPhones();
            string TestData = "Iphone 11";
            AnPhones.PhoneModel = TestData;
            Assert.AreEqual(AnPhones.PhoneModel, TestData);
        }
        [TestMethod]
        public void PhoneDescriptionOK()
        {
            clsPhones AnPhones = new clsPhones();
            string TestData = "256gb space grey";
            AnPhones.PhoneDescription = TestData;
            Assert.AreEqual(AnPhones.PhoneDescription, TestData);
        }

        [TestMethod]
        public void PhoneWeightOK()
        {
            clsPhones AnPhones = new clsPhones();
            string TestData = "25 g";
            AnPhones.PhoneWeight = TestData;
            Assert.AreEqual(AnPhones.PhoneWeight, TestData);
        }
        [TestMethod]
        public void PhoneColourOK()
        {
            clsPhones AnPhones = new clsPhones();
            string TestData = "White";
            AnPhones.PhoneColour = TestData;
            Assert.AreEqual(AnPhones.PhoneColour, TestData);
        }
        [TestMethod]
        public void PhoneId()
        {
            clsPhones AnPhones = new clsPhones();
            Int16 TestData = 1;
            AnPhones.PhoneId = 1;
            Assert.AreEqual(AnPhones.PhoneId, TestData);
        }





    }



}
