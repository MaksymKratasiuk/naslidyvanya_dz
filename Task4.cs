using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace naslidyvanya_dz
{
    abstract class Worker
    {
        public abstract void Print();
    }

    class President : Worker
    {
        public override void Print()
        {
            Console.WriteLine("I am the President.");
        }
    }

    class Security : Worker
    {
        public override void Print()
        {
            Console.WriteLine("I am the Security.");
        }
    }

    class Manager : Worker
    {
        public override void Print()
        {
            Console.WriteLine("I am the Manager.");
        }
    }

    class Engineer : Worker
    {
        public override void Print()
        {
            Console.WriteLine("I am the Engineer.");
        }
    }

    internal class Task4
    {
        public static void task4()
        {
            Worker president = new President();
            president.Print(); // выводит "I am the President."

            Worker security = new Security();
            security.Print(); // выводит "I am the Security."

            Worker manager = new Manager();
            manager.Print(); // выводит "I am the Manager."

            Worker engineer = new Engineer();
            engineer.Print(); // выводит "I am the Engineer."

        }
    }
}
