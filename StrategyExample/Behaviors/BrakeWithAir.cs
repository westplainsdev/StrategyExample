using System;
using StrategyExample.Interfaces;

namespace StrategyExample.Behaviors
{
    public class BrakeWithAir : IBrakeBehavior
    {
        public void brake()
        {
            Console.WriteLine("Air brakes applied");
        }
    }
}