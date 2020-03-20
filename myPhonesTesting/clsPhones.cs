using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPhonesTesting
{
    class clsPhones
    {
        private Int16 mPhoneId;
        private DateTime mDatePhoneAdded;
        private string mPhoneMake;
        private bool mInStock;
        private string mPhoneModel;
        private string mPhoneDescription;
        private decimal mPrice;
        private string mPhoneWeight;
        private string mPhoneColour;

        public Int16 PhoneId
        {
            get
            {
                return mPhoneId;
            }

            set
            {
                mPhoneId = value;
            }
        }

        public DateTime DatePhoneAdded 
        {
            get
            {
                return mDatePhoneAdded;
            }

    set
            {
                mDatePhoneAdded = value;
            }
        }

        public string PhoneMake 
        {
            get
            {
                return mPhoneMake;
            }

    set
            {
                mPhoneMake = value;
            }
        }

        public bool InStock 
       {
            get
            {
                return mInStock;
            }

    set
            {
                mInStock = value;
            }
        }
        public int Price 
       {
    get
            {
                return mPrice;
           }

  set
            {
                mPrice = value;
           }
       }

        internal bool Find(int phoneId)
        {
            throw new NotImplementedException();
        }

        public string PhoneModel 
         {
            get
            {
                return mPhoneModel;
            }

    set
            {
                mPhoneModel = value;
            }
        }
        public string PhoneDescription
        {
            get
            {
                return mPhoneDescription;
            }

            set
            {
                mPhoneDescription = value;
            }
        }
        public string PhoneWeight
        {
            get
            {
                return mPhoneWeight;
            }

            set
            {
                mPhoneWeight = value;
            }

        }
        public string PhoneColour
        {
            get
            {
                return mPhoneColour;
            }

    set
            {
                mPhoneColour = value;
            }
        }


        public bool Find(Int16 PhoneId)
        {
            clsDataConnection DB = new clsDataConnection();
           DB.AddParameter("@PhoneId", PhoneId);
            DB.Execute("sproc_tblPhone_SelectAll");
            if (DB.Count == 1)
           {
               mPhoneId = Convert.ToInt16(DB.DataTable.Rows[0]["PhoneId"]);
               mDatePhoneAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DatePhoneAdded"]);
               mPhoneMake = Convert.ToString(DB.DataTable.Rows[0]["PhoneMake"]);
               mInStock = Convert.ToBoolean(DB.DataTable.Rows[0]["InStock"]); ;
               mPhoneModel = Convert.ToString(DB.DataTable.Rows[0]["PhoneModel"]);
               mPhoneDescription = Convert.ToString(DB.DataTable.Rows[0]["PhoneDescription"]);
               mPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["Price"]);
               mPhoneWeight = Convert.ToString(DB.DataTable.Rows[0]["PhoneWeight"]);
               mPhoneColour = Convert.ToString(DB.DataTable.Rows[0]["PhoneColour"]);
               return true;
            }
            else
            {
               return false;
            }
        }
      
    }
}
