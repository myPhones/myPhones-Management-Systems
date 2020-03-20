using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace myPhonesTesting
{
    [TestClass]
    public class TestDateAddedFound
    {
        [TestMethod]
        public void TestMethod1()
        {
            clsPhones AnPhones = new clsPhones();
            Boolean Found = false;
            Boolean OK = true;
            Int16 PhoneId = 01;
            Found = AnPhones.Find(PhoneId);

            if (AnPhones.DatePhoneAdded != Convert.ToDateTime("05/03/2020"))
            {
                OK = false;

            }
            Assert.IsTrue(OK);
        }
    }
}
