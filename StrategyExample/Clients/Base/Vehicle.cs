using StrategyExample.Interfaces;

namespace StrategyExample.Clients.Base
{
    public abstract class Vehicle
    {
        private IBrakeBehavior _brakeBehavior;

        protected Vehicle()
        {
            // empty constructor
        }

        protected Vehicle(IBrakeBehavior brakeBehavior)
        {
            this._brakeBehavior = brakeBehavior;
        }

        public void ApplyBrake()
        {
            this._brakeBehavior.brake();
        }

        public void SetBrakeBehavior(IBrakeBehavior brakeType)
        {
            this._brakeBehavior = brakeType;
        }
    }
}