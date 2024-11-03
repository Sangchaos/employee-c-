using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CONGTY
{
    public class Samsung : Devices 
    {
        public Samsung(string nameDivice, Date yob, string color, string producer, float price) : base(nameDivice, yob, color, producer, price)
        {
        }

        public override void HoatDong()
        {
            base.UsingGSM();
        }
    }
}