using System;

namespace Передача_параметров
{
    class MyHello
    {
        static void Main(string[] args)
        {
            Console.WriteLine("myhello");
            string name;
            name = Console.ReadLine();
            Console.WriteLine($"Привет, {name}");
        }
    }
}
