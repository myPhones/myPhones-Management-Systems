using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace myPhonesTesting
{
    [TestClass]
    public class TestPhoneNoFound
    {
        [TestMethod]
        public void TestMethod1()
        {
            clsPhones AnPhones = new clsPhones();
            Boolean Found = false;
            Boolean OK = true;
            Int16 PhoneId = 01;
            Found = AnPhones.Find(PhoneId);
            if (AnPhones.PhoneId != 01)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}
