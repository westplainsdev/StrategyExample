using System;
using StrategyExample.Clients;
using StrategyExample.Behaviors;

namespace StrategyExample
{
/* This is a client that can use braking algorithms interchangeably */

    public static class Program
    {
        private static void Main(string[] args)
        {
            var sedanCar = new Sedan();
            sedanCar.ApplyBrake(); // This will invoke class "Brake"

            var suvCar = new SportUtility();
            suvCar.ApplyBrake(); // This will invoke class "BrakeWithABS"

            // set brake behavior dynamically
            suvCar.SetBrakeBehavior(new StandardBrake());
            suvCar.ApplyBrake(); // This will invoke class "Brake"

            var semiTruck = new Truck();
            semiTruck.ApplyBrake(); // this will invoke class "BrakeWithAir"

            // set the brake behavior from the constructor
            var pickup = new Truck(new BrakeWithABS());
            pickup.ApplyBrake(); // this will invoke class "BrakeWithABS"

            var hybrid = new Sedan(new BadBrake());
            hybrid.ApplyBrake(); //this will invoke class "BadBrake"
            hybrid.SetBrakeBehavior(new BrakeWithABS());
            hybrid.ApplyBrake(); // this will invoke class "BrakeWithABS"

            Console.ReadLine();
        }
    }
}