
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace myPhonesTesting
{
    [TestClass]
    public class TestTimeFound
    {
        [TestMethod]
        public void TestMethod1()
        {
            {
                clsOrder OrderTest = new clsOrder();
                Boolean Found = false;
                Int32 OrderID = 1;
                Boolean OK = true;
                Found = OrderTest.Find(OrderID);

                if (OrderTest.TimeAdded != Convert.ToDateTime("15:30"))
                {
                    OK = false;
                }

                Assert.IsTrue(OK);
            }
        }
        }
    }

