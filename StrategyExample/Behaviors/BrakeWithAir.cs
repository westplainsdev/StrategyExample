using System;
using StrategyExample.Interfaces;

namespace StrategyExample.Behaviors
{
    public class BrakeWithAir : IBrakeBehavior
    {
        public void Brake()
        {
            Console.WriteLine("Air brakes have been applied.");
        }
    }
}