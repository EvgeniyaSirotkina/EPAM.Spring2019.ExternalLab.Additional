using System;
using AdditionalOOPModel.Interfaces;

namespace AdditionalOOPModel.Models
{
    class PlatformTransportation : IGetMass
    {
        private const TypeOfCargo type = TypeOfCargo.Platform;

        public const double containerMass = 0;

        public PlatformTransportation()
        {
            Mass = 0;
        }

        public PlatformTransportation(double mass)
        {
            Mass = mass;
        }

        public TypeOfCargo GetTypeOfCargo() => type;

        public double Mass { get; set; }

        public double GetMass() => (containerMass + Mass);

        public override string ToString() => String.Format("{0}: {1:0.00} kg", GetType().Name, GetMass());
    }
}
