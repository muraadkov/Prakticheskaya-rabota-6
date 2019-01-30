using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person firstPerson = new Person
            {
                Name = "Петя",
                Age = 15
            };
            Person secondPerson = new Person
            {
                Name = "Петя",
                Age = 28
        };
            Console.WriteLine("Возраст первого человека: " + firstPerson.Age);
            Console.WriteLine("Имя первого человека: " + firstPerson.Name);
            Console.WriteLine("Возраст второго человека: " + secondPerson.Age);
            Console.WriteLine("Имя второго человека: " + secondPerson.Name);
            Console.WriteLine("--------------------------------------------------------");
            Console.Write("Одинаковое имя: ");
            Console.WriteLine(firstPerson.Name == secondPerson.Name);
            Console.Write("Разное имя: ");
            Console.WriteLine(firstPerson.Name != secondPerson.Name);
            Console.Write("Одинаковый возраст: ");
            Console.WriteLine(firstPerson.Age == secondPerson.Age);
            Console.Write("Разный возраст: ");
            Console.WriteLine(firstPerson.Age != secondPerson.Age);
            Console.Read();
        }
    }
}
