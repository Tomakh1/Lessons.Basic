using System;

namespace Task1
{

    class Array
    {
        object[] array = new object[0];

        public void Add(object elem)
        {
            object[] newarray = new object[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
            {
                newarray[i] = array[i];
            }
            newarray[array.Length] = elem;
            array = newarray;

        }

        public void Remove(int elem)
        {
            /*int k = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == elem)
                {
                    k = i;
                    break;
                }
            }*/

            object[] newarray = new object[array.Length - 1];
            for (int i = 0, j = 0; i < array.Length; i++, j++)
            {
                if (i != elem)
                {
                    newarray[j] = array[i];
                }
                else
                {
                    j--;
                    continue;

                }
                

            }
            



        }

        public object Getelem(int i)
        {
            if (i >= 0 && i < array.Length)
            {
                return array[i];


            }
            else
            {
                return "Not Found";
            }


        }

        public int Lenght()
        {
            return array.Length;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Array arr = new Array();
            arr.Add(5);
            arr.Add(10);
            arr.Add(50);
            arr.Add("aaaa");
            arr.Add(4);
            arr.Remove(1);
            object a = arr.Getelem(2);
            arr.Lenght();
            Console.WriteLine(a);
            Console.WriteLine(arr.Lenght());
            Console.ReadKey();

        }
    }
}
