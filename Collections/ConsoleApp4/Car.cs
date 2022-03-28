using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class Car:Human
    {
        public string CarNum { get; set; }
        public string CarBrand { get; set; }
        public int CarPrice { get; set; }

        //public Car(string carNum,string carBrand,int carPrice)
        //{
        //    this.CarNum = carNum;
        //    this.CarBrand = carBrand;
        //    this.CarPrice = carPrice;
        //}

        //public void HaveCar(bool haveCar)
        //{
        //    if (haveCar)
        //    {
        //        Console.WriteLine(CarNum + "__" + CarBrand + "__"+ CarPrice);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Doesn`t have");
        //    }
        //}

    }
}
