using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class Person
    {
        public string Name;
        public int Age;
        public bool HasPet;

        public void Greeting()
        {
            Console.WriteLine("Hi, my name is " + Name + " and my age is " + Age);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            person.Name = "Dzoni B";
            person.Age = 32;
            person.HasPet = false;

            person.Greeting();
        }
    }
}
