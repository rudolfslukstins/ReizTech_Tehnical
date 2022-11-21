using System;
using ClockAngle.Model;

namespace ClockAngle.ClockAngleTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello User!\nPlease input minutes: ");
            var minutes = int.Parse(Console.ReadLine());

            Console.Write("Please input hours: ");
            var hours = int.Parse(Console.ReadLine());

            var calculator = new Calculation();
            Console.WriteLine(
                $"Lesser angle in degrees between {hours} and {minutes} is {calculator.CalculateDegrees(hours, minutes)}°");
        }
    }
}
