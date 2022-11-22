using System;
using ClockAngle.Exceptions;
using ClockAngle.Interface;

namespace ClockAngle.Model
{
    public class Calculation : ICalculation
    {
        public int CalculateDegrees(int hours, int minutes)
        {
            var minutesToDegrees = minutes * 6;
            var hoursToDegrees = hours * 30;
            var degreesBetween = Math.Abs(hoursToDegrees - minutesToDegrees);

            if (hours <= 0 || minutes < 0)
            {
                throw new InvalidInputException();
            }

            if (hours > 12 || minutes > 60)
            {
                hours %= 12;
                minutes %= 60;
                minutesToDegrees = minutes * 6;
                hoursToDegrees = hours * 30;
                degreesBetween = Math.Abs(hoursToDegrees - minutesToDegrees);
                if (degreesBetween > 180)
                {
                    return 360 - degreesBetween;
                }

                return degreesBetween;
            }

            if (degreesBetween > 180)
            {
                return 360 - degreesBetween;
            }

            return degreesBetween;
        }
    }
}