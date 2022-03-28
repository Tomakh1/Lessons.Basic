using System;
using System.Collections.Generic;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<Human> human = new List<Human>();
            //human.Add(new Human { Id = 111, Name = "Tomy", Age = 23, IsMaried = false,  }) ;

            List<Car> car = new List<Car>();
            car.Add(new Car { Id = 111, Name = "Tomy", Age = 23, Salary = 1000000, IsMaried = false, CarBrand = "BMW", CarNum = "88oo888", CarPrice = 50000000 });
            List<Car> car1 = new List<Car>();
            car1.Add(new Car { Id = 112, Name = "Jony", Age = 30, Salary = 400000, IsMaried = true, CarBrand = "Toyota", CarNum = "55uo355", CarPrice = 24000000, FamilyMember = "Wife,Son" });
            List<Car> car2 = new List<Car>();
            car2.Add(new Car { Id = 113, Name = "Annie", Age = 45, Salary = 650000, IsMaried = true, CarBrand = "Nissan", CarNum = "31tt111", CarPrice = 20000000, FamilyMember = "Husband,Doughter" });
            Car human = new Car();
            Console.Write("Enter Id___ ");
            human.Id = Convert.ToInt32(Console.ReadLine());
            switch (human.Id)
            {
                case 111:
                    foreach(var item in car)
                    {
                        Console.WriteLine("Id __" + item.Id+"  , Age__"+item.Age+"  , Salary___" + item.Salary+"  , Car Brand ___" + item.CarBrand+"  , Car Number___" + item.CarNum+"  , Car Price___" + item.CarPrice);
                    }
                    break;
                case 112:
                    foreach(var item in car1)
                    {
                        Console.WriteLine("Id __" + item.Id + "  , Age__" + item.Age + "  , Salary___" + item.Salary + "  , Car Brand ___" + item.CarBrand + "  , Car Number___" + item.CarNum + "  , Car Price___" + item.CarPrice+"  , Family Members ___" + item.FamilyMember); 
                    }
                    break;
                case 113:
                    foreach(var item in car2)
                    {
                        Console.WriteLine("Id __" + item.Id + "  , Age__" + item.Age + "  , Salary___" + item.Salary + "  , Car Brand ___" + item.CarBrand + "  , Car Number___" + item.CarNum + "  , Car Price___" + item.CarPrice + "  , Family Members ___" + item.FamilyMember);
                    }
                    break;
                default:
                    Console.WriteLine("Identifier not found");
                    break;

            }


        }
    }
}
