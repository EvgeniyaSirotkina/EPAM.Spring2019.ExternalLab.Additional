using AdditionalOOPModel.Interfaces;

namespace AdditionalOOPModel.Models
{
    class Ferry
    {
        public Ferry()
        {
            LoadCapacity = 0;
            Loads = null;
        }

        public Ferry(double loadCapacity, IGetMass[] loads)
        {
            LoadCapacity = loadCapacity;
            Loads = loads;
        }

        public double LoadCapacity { get; set; }

        public IGetMass[] Loads { get; set; }

        public bool IfStandFerry()
        {
            double totalWeight = 0;
            foreach (var item in Loads)
            {
                totalWeight += item.GetMass();
            }
            if (totalWeight > LoadCapacity)
                return false;

            return true;
        }
    }
}
