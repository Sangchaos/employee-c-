using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CONGTY
{
    public class Iphone : Devices, IWifi, I5G, IGPRS
    {
        public Iphone(string nameDivice, Date yob, string color, string producer, float price) : base(nameDivice, yob, color, producer, price)
        {
        }

        public override void HoatDong()
        {
            base.UsingGSM();
            UsingWifi();
            UsingGPRS();
            Using5G();
        }

        public void Using5G()
        {
            throw new NotImplementedException();
        }

        public void UsingGPRS()
        {
            throw new NotImplementedException();
        }

        public void UsingWifi()
        {
            throw new NotImplementedException();
        }
    }
}