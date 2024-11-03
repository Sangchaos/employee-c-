using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CONGTY
{
    public abstract class Devices : IGSM
    {
        private string nameDivice;
        private Date yob;
        private string color;
        private string producer;
        private float price;

        public Devices(string nameDivice, Date yob, string color,string producer, float price)
        {
            NameDivice = nameDivice;
            Yob = yob;
            Color = color;
            Producer = producer;
            Price = price;
        }


        public string NameDivice { get => nameDivice; set => nameDivice = value; }
        public Date  Yob { get => yob; set => yob = value; }
        public string  Color { get => color; set => color = value; }
        public string Producer { get => producer; set => producer = value; }
        public float Price { get => price; set => price = value; }

        public abstract void HoatDong();
        public virtual void UsingGSM()
        {
           
        }

        public override string ToString()
        {
            return $"Device Name: {nameDivice}\n" +
                   $"Year of Manufacture: {yob}\n" +
                   $"Color: {color}\n" +
                   $"Producer: {producer}\n" +
                   $"Price: {price}$";
        }


    }
}