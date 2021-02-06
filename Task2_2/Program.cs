using System;

namespace Task2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1) Default Russian 'С'");
            Console.WriteLine("2) Choose any char");

            int choose = Convert.ToInt32(Console.ReadLine());

            char ch;
            if (choose == 1)
            {
                ch = 'С';
            }
            else
            {
                Console.WriteLine("Write any char");
                ch = Convert.ToChar(Console.ReadLine());
            }


            string path = "../../../";

            Console.WriteLine("Write file name (input.txt)");
            string fileName = Console.ReadLine();

            string filePath = path + fileName;

            Console.WriteLine("Choose char place:");
            Console.WriteLine("1) Begin");
            Console.WriteLine("2) End");

            bool begin = Convert.ToInt32(Console.ReadLine()) == 1 ? true : false;

            FileHandler fileHandler = new FileHandler();

            fileHandler.ProcessFile(filePath, ch, begin);
        }
    }
}