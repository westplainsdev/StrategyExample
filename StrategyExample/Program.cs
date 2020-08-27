using System;
using StrategyExample.Clients;
using StrategyExample.Behaviors;
using StrategyExample.Clients.Base;

namespace StrategyExample
{
/* This is a client that can use braking algorithms interchangeably */

    public static class Program
    {
        private static void Main(string[] args)
        {
            var sedanCar = new Sedan();
            Vehicle.ToString("Honda", "Accord");
            sedanCar.ApplyBrake(); // This will invoke class "Brake"

            var suvCar = new SportUtility();
            Vehicle.ToString("Toyota", "Four Runner");
            suvCar.ApplyBrake(); // This will invoke class "BrakeWithABS"

            // set brake behavior dynamically
            suvCar.SetBrakeBehavior(new StandardBrake());
            suvCar.ApplyBrake(); // This will invoke class "Brake"

            var semiTruck = new Truck();
            Vehicle.ToString("Kenworth", "Roadrunner");
            semiTruck.ApplyBrake(); // this will invoke class "BrakeWithAir"

            // set the brake behavior from the constructor
            var pickup = new Truck(new BrakeWithAbs());
            Vehicle.ToString("Ford", "F150");
            pickup.ApplyBrake(); // this will invoke class "BrakeWithABS"
            pickup.SetBrakeBehavior(new BrakeWithAir());

            var hybrid = new Sedan(new BadBrake());
            Vehicle.ToString("Toyota", "Prius");
            hybrid.ApplyBrake(); //this will invoke class "BadBrake"
            hybrid.SetBrakeBehavior(new BrakeWithAbs());
            hybrid.ApplyBrake(); // this will invoke class "BrakeWithABS"

            Console.ReadLine();
        }
    }
}