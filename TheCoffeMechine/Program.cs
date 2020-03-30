using System;

namespace TheCoffeMechine
{
    class Program
    {
        static void Main(string[] args)
        {
         
            CoffePowder coffe = new CoffePowder(100);
            WaterGalon water = new WaterGalon(1000);
            CoffeMechine yummycoffe = new CoffeMechine(coffe, water);

            Console.WriteLine("check " + yummycoffe.checkAvailability());
            String result = yummycoffe.makeEsspresso();
            Console.WriteLine("result " + result);

            Console.WriteLine("check " + yummycoffe.checkAvailability());
            result = yummycoffe.makeEsspresso();
            Console.WriteLine("result " + result);

            Console.WriteLine("check " + yummycoffe.checkAvailability());
            result = yummycoffe.makeEsspresso();
            Console.WriteLine("result " + result);

            Console.WriteLine("check " + yummycoffe.checkAvailability());
            result = yummycoffe.makeEsspresso();
            Console.WriteLine("result " + result);

            Console.WriteLine("check " + yummycoffe.checkAvailability());
            result = yummycoffe.makeEsspresso();
            Console.WriteLine("result " + result);

            Console.WriteLine("check " + yummycoffe.checkAvailability());
            result = yummycoffe.makeEsspresso();
            Console.WriteLine("result " + result);

            Console.WriteLine("check " + yummycoffe.checkAvailability());
        }
    }
}
