using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace myPhonesTesting
{
    [TestClass]
    public class TestPhoneNotFound
    {
        [TestMethod]
        public void FindMethodOK()
        {
            clsPhones AnPhones = new clsPhones();
            Boolean Found = false;
            Int16 PhoneId = 1;
            Found = AnPhones.Find(PhoneId);
            Assert.IsTrue(Found);
        }
    }
}
