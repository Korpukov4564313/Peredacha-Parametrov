using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int jorik1 = Convert.ToInt32(Console.ReadLine());
            int jorik2 = Convert.ToInt32(Console.ReadLine());
            if (Conditions(jorik1, jorik2))
            {
                Console.WriteLine("В числе А больше цифр,чем в числе Б");
            }
            else 
                if(conditions(jorik1, jorik2))
            {
                Console.WriteLine("В числе Б больше цифр,чем в числе А");
            }
            else
            {
                Console.WriteLine("Количество цифр одинаково");
            }
        }
        static bool Conditions(int Jorik1, int Jorik2)
        {
            while (Jorik1 > 0 && Jorik2 > 0)
            {
                Jorik1 = Jorik1 / 10;
                Jorik2 = Jorik2 / 10;
            }
            if (Jorik1 > 0)
                return true;
            return false;
        }
        static bool conditions(int Jorik1, int Jorik2)
        {
            while (Jorik1 > 0 && Jorik2 > 0)
            {
                Jorik1 = Jorik1 / 10;
                Jorik2 = Jorik2 / 10;
            }
            if (Jorik1 < 0)
                return true;
            return false;
        }
    }
}