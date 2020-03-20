using System;

namespace myPhonesTesting
{
    public class clsOrder
    {
        private int mOrderId;
        private int mOrderLineID;
        private DateTime mDateAdded;
        private DateTime mTimeAdded;
        private bool mShippedAdded;
        

        public int OrderID
        {
            get
            {
                return mOrderId;
               

            }
            set
            {
                mOrderId = value;
            }

        }

       

        public int OrderLineID
        {
            get
            {
                return mOrderLineID;

            }
            set
            {
                mOrderLineID = value;
            }

        }

 

        public DateTime DateAdded

        {
            get
            {
                return mDateAdded;

            }
            set
            {
                mDateAdded = value;
            }

        }

       

        public DateTime TimeAdded

        {
            get
            {
                return mTimeAdded;

            }
            set
            {
                mTimeAdded = value;
            }

        }
        public bool ShippedAdded
        {
            get
            {
                return mShippedAdded;

            }

            set
            {
                mShippedAdded = value;
            }
        }

        

        public bool Find(int OrderId)
        {

            
            mOrderId = 1;
            mOrderLineID = 1;
            mDateAdded = Convert.ToDateTime("20/02/2020");
            mTimeAdded = Convert.ToDateTime("15:30");
            mShippedAdded = Convert.ToBoolean("True");
           

            return true;
        }
    }
}