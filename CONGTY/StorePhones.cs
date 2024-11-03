using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CONGTY
{
    public class StorePhones : Devices
    {
        private string address;
        private string contactNumber;

        public StorePhones(string nameDivice, Date yob, string color, string producer, float price, string address, string contactNumber) : base(nameDivice, yob, color, producer, price)
        {
            Address = address;
            ContactNumber = contactNumber;
        }

        public string Address { get => address; set => address = value; }
        public string ContactNumber { get => contactNumber; set => contactNumber = value; }

        public override void HoatDong()
        {
            throw new NotImplementedException();
        }

    }
}