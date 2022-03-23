using System;

namespace Market
{
    class Program
    {
        static void Main(string[] args)
        {
            Shose shose = new Shose(25000, 42);
            shose.GetPrice();
            shose.GetSize();


            Clothes clothes = new Clothes(30000, 36);
            Console.WriteLine("IsBaby" +" " +( clothes.IsBaby=true) );
            Console.WriteLine("Season"+" "+(clothes.Seasons="Summer"));
            Console.WriteLine("Size"+" "+(clothes.Size=36));
        }
    }
}