using System;

namespace Car
{
    public class Car
    {
        public int doors=4;
        public void Doors(int a)
        {
            Console.WriteLine("Doors count` " +a);
        }
    }
    
    public class BMW:Car
    {
        public string fuel;
        public BMW()
        {

        }
        public BMW(string a)
        {
            fuel = a;
            Console.WriteLine("Fuel: {0}",fuel);

        }

        public string Color { get; set; }
        public void Colors(string b)
        {
            Console.WriteLine("Color : " + b);
        }

        public void Fuel(string fuel)
        {
            Console.WriteLine("Fuel: " + fuel);
        }
    }
    
    public class Series_4:BMW
    {
        //public string fuel { get; set; }
        //public string Color { get; set; }

        //public Series_4(string color)
        //{
        //    Color = color;
        //}
    }
    
    public class Series_X6:BMW
    {
        
        //public Series_X6(string color)
        //{
        //    Color = color;
        //    Console.WriteLine(Color);
        //}
       
        //public void fuel()
        //{
        //    Console.WriteLine();
        //}
    }
    
    
    class Program
    {
        static void Main(string[] args)
        {
            Series_X6 series_X6 = new Series_X6(/*"red"*/);
            Console.WriteLine("BMW ` Series_X6 parametres : ");
            series_X6.Doors(4);
            series_X6.Fuel("Diesel");
            series_X6.Colors("Red");
            Series_4 series_4 = new Series_4(/*"Black"*/);
            Console.WriteLine("BMW ` Series_4 parametres : ");
            series_4.Fuel("Benzin");
            series_4.Doors(2);
            series_4.Colors("Black");
            //Console.WriteLine(series_X6);
        }
    }
}
