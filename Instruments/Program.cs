using System;
namespace Instruments
{
    interface Instrument
    {
        void play();
    }
    class Guitar : Instrument
    {
        public int amountStrings;
        public Guitar(int amountStrings)
        {
            this.amountStrings = amountStrings;
        }
        public void play()
        {
            Console.WriteLine($"Играет гитара с {amountStrings} струнами");
        }
    }
    class Drum : Instrument
    {
        public int size;
        public Drum(int size)
        {
            this.size = size;
        }
        public void play()
        {
            Console.WriteLine($"Играет барабан размером {size}");
        }
    }
    class Trumpet : Instrument
    {
        public int diameter;
        public Trumpet(int diameter)
        {
            this.diameter = diameter;
        }

        public void play()
        {
            Console.WriteLine($"Играет труба диаметром {diameter}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string KEY = "До мажор";
            Guitar gui = new Guitar(6);
            Drum dru = new Drum(10);
            Trumpet tru = new Trumpet(4);
            Instrument[] instruments = {gui, dru, tru};
            foreach (Instrument element in instruments)
            {
                element.play();
            }
        }
    }
}