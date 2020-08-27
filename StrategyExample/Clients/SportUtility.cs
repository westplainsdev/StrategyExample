
using StrategyExample.Behaviors;

namespace StrategyExample.Clients
{
    public class SportUtility : Base.Vehicle
    {
        public SportUtility()
        {
            SetBrakeBehavior(new BrakeWithAbs());
        }
    }
}