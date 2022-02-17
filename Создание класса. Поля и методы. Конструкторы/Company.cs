using System;

namespace Создание_класса._Поля_и_методы._Конструкторы
{
    class Company
    {
        public string name;
        public int persons;
        public int money;
        public Company (string name, int persons, int money)
        {
            this.name = name;
            this.persons = persons;
            this.money = money;
        }
        public void show()
        {
            Console.WriteLine($"В компании {name} работают {persons} сотрудников");
            Console.WriteLine($"Фонд зарплаты {money}");
        }
        public int averageSalary()
        {
            return money / persons;
        }
        
        public int maxPersons(int salary)
        {
            return money / salary;
        }
        public int minus(int minus1,int minus2)
        {
            return money * (minus1 + minus2) / 100;
        }
    }
    class Program
    {
        public static void Main()
        {
            Company factory = new Company("Премьер", 100, 100000);
            factory.show();
            Console.WriteLine($"Средняя зарплата {factory.averageSalary()}");
            Console.WriteLine($"Отчисления {factory.minus(13, 4)}");
            Console.WriteLine("Средняя зарплата?");
            int average = int.Parse(Console.ReadLine());
            Console.WriteLine($"Кол-во  сотрудников {factory.maxPersons(average)}");
        }
    }
}
