using System;
using ClockAngle.Exceptions;
using ClockAngle.Interface;

namespace ClockAngle.Model
{
    public class Calculation : ICalculation
    {
        public int CalculateDegrees(int hours, int minutes)
        {
            int minutesToDegrees = minutes * 6;
            int hoursToDegrees = hours * 30;
            int DegreesBetween = Math.Abs(hoursToDegrees - minutesToDegrees);

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
                DegreesBetween = Math.Abs(hoursToDegrees - minutesToDegrees);
                if (DegreesBetween > 180)
                {
                    return 360 - DegreesBetween;
                }

                return DegreesBetween;
            }

            if (DegreesBetween > 180)
            {
                return 360 - DegreesBetween;
            }

            return DegreesBetween;
        }
    }
}