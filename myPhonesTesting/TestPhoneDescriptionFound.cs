using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace myPhonesTesting
{
    [TestClass]
    public class TestPhoneDescriptionFound
    {
        [TestMethod]
        public void TestMethod1()
        {
            clsPhones AnPhones = new clsPhones();
            Boolean Found = false;
            Boolean OK = true;
            Int16 PhoneId = 01;
            Found = AnPhones.Find(PhoneId);
            if (AnPhones.PhoneDescription != "256gb space grey")
            {
                OK = false;

            }
            Assert.IsTrue(OK);
        }
    }
}
