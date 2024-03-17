using apbd28_cw3.Exceptions;

namespace apbd28_cw3.Containers;

public class LiquidContainer : Container
{
    public LiquidContainer(double cargoWeight) : base(cargoWeight)
    {
        
    }

    public override void Load(double cargoWeight)
    {
        base.Load(cargoWeight);
        throw new NotImplementedException();
    }
}