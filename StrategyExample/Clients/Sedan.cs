using StrategyExample.Interfaces;
using StrategyExample.Behaviors;

namespace StrategyExample.Clients
{
    public class Sedan : Base.Vehicle
    {
        public Sedan()
        {
            SetBrakeBehavior(new StandardBrake());
        }

        public Sedan(IBrakeBehavior brakeBehavior)
        {
            SetBrakeBehavior(brakeBehavior);
        }
    }
}