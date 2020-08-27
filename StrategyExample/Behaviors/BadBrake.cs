using System;
using StrategyExample.Interfaces;

namespace StrategyExample.Behaviors
{
    public class BadBrake : IBrakeBehavior
    {
        public void brake()
        {
            Console.WriteLine("this is a bad brake");
        }

    }
}