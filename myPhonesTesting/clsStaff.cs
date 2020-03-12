using System;

namespace myPhonesTesting
{
    public class clsStaff
    {
        public DateTime staffJoined;

        public bool Active { get; internal set; }
        public DateTime StaffJoined { get; internal set; }
        public Int16 staffId { get; internal set; }
        public Int16 orderId { get; internal set; }

        public string staffFullName { get; internal set; }
        public string staffAddress { get; internal set; }
        public string staffJobTitle { get; internal set; }

        internal bool Find(int staffFullName)
        {
            return true;
        }

        internal bool Find(string staffFullName)
        {
            throw new NotImplementedException();
        }
        public bool staffAdminRights { get; internal set; }
        
    }
}