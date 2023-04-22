using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace naslidyvanya_dz
{
    class Device
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Device(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public virtual void Sound()
        {
            Console.WriteLine("This device makes a sound.");
        }

        public void Show()
        {
            Console.WriteLine("Device name: " + Name);
        }

        public void Desc()
        {
            Console.WriteLine("Device description: " + Description);
        }
    }

    class Kettle : Device
    {
        public Kettle(string name, string description) : base(name, description)
        {
        }

        public override void Sound()
        {
            Console.WriteLine("The kettle whistles.");
        }
    }

    class Microwave : Device
    {
        public Microwave(string name, string description) : base(name, description)
        {
        }

        public override void Sound()
        {
            Console.WriteLine("The microwave beeps.");
        }
    }

    class Car : Device
    {
        public Car(string name, string description) : base(name, description)
        {
        }

        public override void Sound()
        {
            Console.WriteLine("The car honks.");
        }
    }

    class Steamship : Device
    {
        public Steamship(string name, string description) : base(name, description)
        {
        }

        public override void Sound()
        {
            Console.WriteLine("The steamship whistle blows.");
        }
    }
    internal class Task2
    {
        public static void task2()
        {
            Kettle kettle = new Kettle("Kettle", "A device used to boil water.");
            Microwave microwave = new Microwave("Microwave", "A device used to heat food.");
            Car car = new Car("Car", "A motorized vehicle used for transportation.");
            Steamship steamship = new Steamship("Steamship", "A vessel powered by steam engines.");

            kettle.Show();
            kettle.Sound();
            kettle.Desc();
            Console.WriteLine();
            microwave.Show();
            microwave.Sound();
            microwave.Desc();
            Console.WriteLine();
            car.Show();
            car.Sound();
            car.Desc();
            Console.WriteLine();
            steamship.Show();
            steamship.Sound();
            steamship.Desc();
        }
    }
}
