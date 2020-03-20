using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace myPhonesTesting
{
    [TestClass]
    public class TestPhoneMakeFound
    {
        [TestMethod]
        public void TestMethod1()
        {
            clsPhones AnPhones = new clsPhones();
            Boolean Found = false;
            Boolean OK = true;
            Int16 PhoneId = 01;
            Found = AnPhones.Find(PhoneId);
            if (AnPhones.PhoneMake != "iphone")
            {
                OK = false;

            }
            Assert.IsTrue(OK);


        }
    }
}
