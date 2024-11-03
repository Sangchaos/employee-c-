using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CONGTY
{
    public class LG : Devices, IGPRS
    {
        public LG(string nameDivice, Date yob, string color, string producer, float price) : base(nameDivice, yob, color, producer, price)
        {
        }

        public void UsingGPRS()
        {
            throw new NotImplementedException();
        }

        public override void HoatDong()
        {
            base.UsingGSM();
            UsingGPRS();
        }
    }
}