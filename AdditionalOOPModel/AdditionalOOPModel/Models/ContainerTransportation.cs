using System;
using AdditionalOOPModel.Interfaces;

namespace AdditionalOOPModel.Models
{
    class ContainerTransportation : IGetMass
    {
        private const TypeOfCargo type = TypeOfCargo.Container;

        public const double containerMass = 50;

        public ContainerTransportation()
        {
            DensityOfMaterial = 0;
            Width = 0;
            Length = 0;
            Height = 0;
        }

        public ContainerTransportation(double densityOfMaterial, double width, double length, double height)
        {
            DensityOfMaterial = densityOfMaterial;
            Width = width;
            Length = length;
            Height = height;
        }

        public double DensityOfMaterial { get; set; }

        public double Width { get; set; }

        public double Length { get; set; }

        public double Height { get; set; }

        public TypeOfCargo GetTypeOfCargo() => type;

        public double GetVolume() => (Width * Length * Height);

        public double GetMass() => (containerMass + DensityOfMaterial * GetVolume());

        public override string ToString() => String.Format("{0}: {1:0.00} kg", GetType().Name, GetMass());
    }
}
