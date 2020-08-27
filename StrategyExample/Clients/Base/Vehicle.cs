using System;
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
            _brakeBehavior = brakeBehavior;
        }

        public void ApplyBrake()
        {
            _brakeBehavior.Brake();
        }

        public void SetBrakeBehavior(IBrakeBehavior brakeType)
        {
            _brakeBehavior = brakeType;
        }
        
        public static void ToString(string vehicleMake, string vehicleModel)
        {
            Console.WriteLine($"This vehicle is a {vehicleMake} {vehicleModel}");
        }
    }
}