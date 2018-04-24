using System;

namespace assignment1_part1
{
    class Program
    {
        static void Main(string[] args)
        {
            var newCar = new Car();
            Console.WriteLine("Enter new car details below");
            Console.Write("Colour: ");
            newCar.SetColour(Console.ReadLine());

            Console.Write("Make: ");
            newCar.SetMake(Console.ReadLine());

            Console.Write("Gearbox type: ");
            newCar.SetGearbox(Console.ReadLine());

            Console.WriteLine(newCar.DescribeCar());

            Console.ReadKey();
        }

    }

    class Car 
    {
        private string _colour;
        private string _make;
        private string _gearbox;

        public string GetColour() 
        {
            return _colour;
        }
        public void SetColour(string col) 
        {
            _colour = col;
        }

        public string GetMake() 
        {
            return _make;
        }

        public void SetMake(string mk)
        {
            _make = mk;
        }

        public string GetGearbox()
        {
            return _gearbox;
        }

        public void SetGearbox(string gbox)
        {
            _gearbox = gbox;
        }

        public string DescribeCar()
        {
            return $"\nThis car is a {_colour} {_make} with a {_gearbox} transmission";
        }
    }
}
