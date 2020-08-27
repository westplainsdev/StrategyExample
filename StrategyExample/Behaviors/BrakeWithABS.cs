using System;
using StrategyExample.Interfaces;

namespace StrategyExample.Behaviors
{
    public class BrakeWithAbs : IBrakeBehavior
    {
        public void Brake()
        {
            Console.WriteLine("ABS brakes have been applied.");
        }
    }
}