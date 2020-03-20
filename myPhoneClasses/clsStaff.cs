using System;

namespace myPhonesTesting
{
    public class clsStaff
    {
        public DateTime staffJoined;
        private string mstaffFullName;
        private string mstaffAddress;
        private string mstaffJobTitle;
        private bool mstaffAdminRights;
        private int mstaffId;
        private int morderId;

        public bool Active { get; internal set; }
        public DateTime StaffJoined { get; internal set; }

        

        public int staffId
        {
            get
            {
                return mstaffId;
            }
            set
            {
                mstaffId = value;
            }
        }
        public int orderId
        {
            get
            {
                return morderId;
            }
            set
            {
                morderId = value;
            }
        }

        public string staffFullName
        {
            get
            {
                return mstaffFullName;
            }
            set
            {
                mstaffFullName = value;
            }
        }
        public string staffAddress
        {
            get
            {
                return mstaffAddress;
            }
            set
            {
                mstaffAddress = value;
            }
        }
        public string staffJobTitle
        {
            get
            {
                return mstaffJobTitle;
            }
            set
            {
                mstaffJobTitle = value;
            }
        }

        public bool Find(string staffFullName)
        {
            mstaffFullName = "vishal soma";
            mstaffAddress = "purley road";
            mstaffJobTitle = "admin";
            mstaffAdminRights = Convert.ToBoolean("true");
            return true;
        }

        public bool Find(Int16 staffId)
        {
            mstaffId = 1;
            morderId = 1;
            return true;
        }

        public bool staffAdminRights
        {
            get
            {
                return mstaffAdminRights;
            }
            set
            {
                mstaffAdminRights = value;
            }
        }
    }
}