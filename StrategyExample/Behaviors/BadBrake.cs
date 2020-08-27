using System;
using StrategyExample.Interfaces;

namespace StrategyExample.Behaviors
{
    public class BadBrake : IBrakeBehavior
    {
        public void Brake()
        {
            Console.WriteLine("This vehicle has bad brakes.");
        }

    }
}