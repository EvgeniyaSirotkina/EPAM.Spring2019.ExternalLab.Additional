using AdditionalOOPModel.Models;

namespace AdditionalOOPModel.Interfaces
{
    interface IGetMass
    {
        TypeOfCargo GetTypeOfCargo();

        double GetMass();
    }
}
