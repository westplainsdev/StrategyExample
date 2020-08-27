using System;
using StrategyExample.Interfaces;

namespace StrategyExample.Behaviors
{
    public class BrakeWithABS : IBrakeBehavior
    {
        public void brake()
        {
            Console.WriteLine("ABS brakes applied");
        }
    }
}