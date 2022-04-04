using System;
using System.IO;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            Files();
        }


        public static void Files()
        {
            if (File.Exists("C:/Users/tamara.khachatryan/Desktop/Homework.txt"))
            {
                File.WriteAllText("C:/Users/tamara.khachatryan/Desktop/Homework.txt", "Hello guys");
            }
            else
            {
                File.Create("C:/Users/tamara.khachatryan/Desktop/Homework.txt");
                File.WriteAllText("C:/Users/tamara.khachatryan/Desktop/Homework.txt", "Hello guys");
            }            
            
            string path = "C:/Users/tamara.khachatryan/Desktop/Homework_1.txt";
            if (File.Exists(path))
            {
                File.WriteAllText(path, "Have a Nice Day :)");
            }
            else
            {
                File.Create("C:/Users/tamara.khachatryan/Desktop/Homework_1.txt");
            }

            File.Copy("C:/Users/tamara.khachatryan/Desktop/Homework.txt", "C:/Users/tamara.khachatryan/Desktop/Homework_2");

            File.ReadAllText("C:/Users/tamara.khachatryan/Desktop/Homework.txt");

            string text = "Good Night";
            File.WriteAllText("C:/Users/tamara.khachatryan/Desktop/Homework.txt", text);
            

            File.Delete(path);
             
            

        }
    }
}
