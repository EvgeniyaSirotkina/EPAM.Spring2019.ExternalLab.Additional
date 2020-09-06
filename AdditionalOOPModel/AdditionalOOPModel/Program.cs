using System;
using AdditionalOOPModel.Helpers;
using AdditionalOOPModel.Interfaces;
using AdditionalOOPModel.Models;

namespace AdditionalOOPModel
{
    class Program
    {
        static void Main()
        {
            var cargo = new IGetMass[]
            {
                new Person(93),
                new TankTransportation(720, 1, 3),              //Petrol
                new Person(55),
                new TankTransportation(820, 1, 3),              //Kerosene
                new ContainerTransportation(7850, 10, 15, 3),   //Iron
                new TankTransportation(820, 1, 3),              //Kerosene
                new ContainerTransportation(7850, 10, 15, 3),   //Iron
                new TankTransportation(850, 1, 3),              //Oil
                new Person(53),
                new ContainerTransportation(7850, 10, 15, 3),   //Iron
                new TankTransportation(850, 1, 3),              //Oil
                new Person(74),
                new ContainerTransportation(7850, 10, 15, 3),   //Iron
                new TankTransportation(850, 1, 3),              //Oil
                new ContainerTransportation(8746, 10, 15, 3),   //Cobolt
                new Person(65),
                new PlatformTransportation(6000),               //Track
                new ContainerTransportation(8930, 10, 15, 3),   //Copper
                new Person(93),
                new ContainerTransportation(8930, 10, 15, 3),   //Copper
                new Person(35),
                new ContainerTransportation(8930, 10, 15, 3),   //Copper
                new Person(80),
                new ContainerTransportation(7280, 10, 15, 3),   //Tin
                new Person(65),
                new ContainerTransportation(7280, 10, 15, 3),   //Tin
                new Person(80)
            };

            var ferry = new Ferry(50000000, cargo);

            foreach (var item in cargo)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            Array.Sort(cargo, new CargoComparer());
            foreach (var item in cargo)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            if (ferry.IfStandFerry())
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");

            Console.ReadKey();
        }
    }
}
