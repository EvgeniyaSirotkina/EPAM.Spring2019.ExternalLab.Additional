using System;
using AdditionalOOPModel.Interfaces;

namespace AdditionalOOPModel.Models
{
    class Person : IGetMass
    {
        private const TypeOfCargo type = TypeOfCargo.Person;

        public Person()
        {
            Mass = 0;
        }

        public Person(double mass)
        {
            Mass = mass;
        }

        public double Mass { get; set; }

        public TypeOfCargo GetTypeOfCargo() => type;

        public double GetMass() => Mass;

        public override string ToString() => String.Format("{0}: {1:0.00} kg", GetType().Name, GetMass());
    }
}
