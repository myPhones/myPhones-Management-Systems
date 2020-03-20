using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace myPhonesTesting
{
    [TestClass]
    public class TestPhoneModelFound
    {
        [TestMethod]
        public void TestMethod1()
        {
            clsPhones AnPhones = new clsPhones();
            Boolean Found = false;
            Boolean OK = true;
            Int16 PhoneId = 01;
            Found = AnPhones.Find(PhoneId);
            if (AnPhones.PhoneModel != "iphone 11")
            {
                OK = false;

            }
            Assert.IsTrue(OK);
        }
    }
}
