using apbd28_cw3.Exceptions;
using apbd28_cw3.Interfaces;

namespace apbd28_cw3.Containers;

public abstract class Container : IContainer
{
    public double CargoWeight { get; set; }

    protected Container(double cargoWeight)
    {
        CargoWeight = cargoWeight;
    }

    public void Unload()
    {
        throw new NotImplementedException();
    }

    public virtual void Load(double cargoWeight)
    {
        if (cargoWeight > 100)
        {
            throw new OverfillException();
        }

        throw new NotImplementedException();
    }
}