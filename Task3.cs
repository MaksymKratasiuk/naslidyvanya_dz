using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace naslidyvanya_dz
{
    class MusicalInstrument
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string History { get; set; }

        public MusicalInstrument(string name, string description, string history)
        {
            Name = name;
            Description = description;
            History = history;
        }

        public virtual void Show_Sound()
        {
            Console.WriteLine("This musical instrument makes a sound.");
        }

        public void Show_Name()
        {
            Console.WriteLine("Musical instrument name: " + Name);
        }

        public void Show_Desc()
        {
            Console.WriteLine("Musical instrument description: " + Description);
        }

        public void Show_History()
        {
            Console.WriteLine("History of the musical instrument: " + History);
        }
    }

    class Violin : MusicalInstrument
    {
        public Violin(string name, string description, string history) : base(name, description, history)
        {
        }

        public override void Show_Sound()
        {
            Console.WriteLine("The violin plays a melodic tune.");
        }
    }

    class Trombone : MusicalInstrument
    {
        public Trombone(string name, string description, string history) : base(name, description, history)
        {
        }

        public override void Show_Sound()
        {
            Console.WriteLine("The trombone produces a deep and rich sound.");
        }
    }

    class Ukulele : MusicalInstrument
    {
        public Ukulele(string name, string description, string history) : base(name, description, history)
        {
        }

        public override void Show_Sound()
        {
            Console.WriteLine("The ukulele creates a cheerful and upbeat melody.");
        }
    }

    class Cello : MusicalInstrument
    {
        public Cello(string name, string description, string history) : base(name, description, history)
        {
        }

        public override void Show_Sound()
        {
            Console.WriteLine("The cello produces a warm and mellow sound.");
        }
    }

    internal class Task3
    {
        public static void task3()
        {

            Violin violin = new Violin("Violin", "A stringed instrument with four strings and a bow.", "The modern violin was developed in the early 16th century in Italy.");
            Trombone trombone = new Trombone("Trombone", "A brass instrument with a sliding tube.", "The trombone evolved from the sackbut in the 15th century.");
            Ukulele ukulele = new Ukulele("Ukulele", "A small, four-stringed instrument with a Hawaiian origin.", "The ukulele was developed in the 19th century from a Portuguese instrument called the machete.");
            Cello cello = new Cello("Cello", "A large stringed instrument with four strings played with a bow.", "The cello evolved from the viola da gamba in the 17th century.");

            violin.Show_Name();
            violin.Show_Sound();
            violin.Show_Desc();
            violin.Show_History();

            trombone.Show_Name();
            trombone.Show_Sound();
            trombone.Show_Desc();
            trombone.Show_History();

            ukulele.Show_Name();
            ukulele.Show_Sound();
            ukulele.Show_Desc();
            ukulele.Show_History();

            cello.Show_Name();
            cello.Show_Sound();
            cello.Show_Desc();
            cello.Show_History();
        }
    }
}
