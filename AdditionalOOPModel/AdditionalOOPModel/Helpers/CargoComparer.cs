using AdditionalOOPModel.Interfaces;
using System.Collections.Generic;

namespace AdditionalOOPModel.Helpers
{
    class CargoComparer : Comparer<IGetMass>
    {
        public override int Compare(IGetMass x, IGetMass y)
        {
            if (x.GetType().Name.Equals(y.GetType().Name))
            {
                return 1 * (x.GetMass().CompareTo(y.GetMass()));
            }
            else
            {
                int indexX = (int)x.GetTypeOfCargo();
                int indexY = (int)y.GetTypeOfCargo();
                return (indexX.CompareTo(indexY));
            }

        }
    }
}
