using StrategyExample.Interfaces;
using StrategyExample.Behaviors;

namespace StrategyExample.Clients
{
    public class Sedan : Base.Vehicle
    {
        public Sedan()
        {
            base.SetBrakeBehavior(new StandardBrake());
        }

        public Sedan(IBrakeBehavior brakeBehavior)
        {
            base.SetBrakeBehavior(brakeBehavior);
        }
    }
}