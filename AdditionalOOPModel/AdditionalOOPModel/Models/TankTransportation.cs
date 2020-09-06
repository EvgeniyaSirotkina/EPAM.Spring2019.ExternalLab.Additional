using System;
using AdditionalOOPModel.Interfaces;

namespace AdditionalOOPModel.Models
{
    class TankTransportation : IGetMass
    {
        private const TypeOfCargo type = TypeOfCargo.Tank;

        public const double containerMass = 35;

        public TankTransportation()
        {
            DensityOfMaterial = 0;
            Radius = 0;
            Height = 0;
        }

        public TankTransportation(double densityOfMaterial, double radius, double height)
        {
            DensityOfMaterial = densityOfMaterial;
            Radius = radius;
            Height = height;
        }

        public double DensityOfMaterial { get; set; }

        public double Radius { get; set; }

        public double Height { get; set; }

        public TypeOfCargo GetTypeOfCargo() => type;

        public double GetVolume() => (2 * Math.PI * Radius * Radius * Height);

        public double GetMass() => (containerMass + DensityOfMaterial * GetVolume());

        public override string ToString() => String.Format("{0}: {1:0.00} kg", GetType().Name, GetMass());
    }
}
