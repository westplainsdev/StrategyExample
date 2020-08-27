using System;
using StrategyExample.Interfaces;

namespace StrategyExample.Behaviors
{
    /* Encapsulated family of Algorithms
   Interface and its implementations */
    public class StandardBrake : IBrakeBehavior
    {
        public void Brake()
        {
            Console.WriteLine("Standard brakes have been applied.");
        }
    }
}