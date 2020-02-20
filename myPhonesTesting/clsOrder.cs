using System;

namespace myPhonesTesting
{
    public class clsOrder
    {
        public DateTime DateAdded { get; internal set; }
        public DateTime TimeAdded { get; internal set; }
        public bool ShippedAdded { get; internal set; }
        public decimal PriceAdded { get; internal set; }

        public bool Find(int OrderId)
        {
            return true;
        }
    }
}