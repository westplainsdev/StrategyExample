using StrategyExample.Behaviors;
using StrategyExample.Interfaces;

namespace StrategyExample.Clients
{
    public class Truck : Base.Vehicle
    {
        public Truck()
        {
            SetBrakeBehavior(new BrakeWithAir());
        }

        // one parameter constructor  
        public Truck(IBrakeBehavior brakeBehavior)
        {
            SetBrakeBehavior(brakeBehavior);
        }
    }
}