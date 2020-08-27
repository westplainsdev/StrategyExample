using StrategyExample.Behaviors;
using StrategyExample.Interfaces;

namespace StrategyExample.Clients
{
    public class Truck : Base.Vehicle
    {
        public Truck()
        {
            base.SetBrakeBehavior(new BrakeWithAir());
        }

        // one parameter constructor  
        public Truck(IBrakeBehavior brakeBehavior)
        {
            base.SetBrakeBehavior(brakeBehavior);
        }
    }
}