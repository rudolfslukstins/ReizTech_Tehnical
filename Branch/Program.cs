using System;
using System.Collections.Generic;

namespace Hierarchy
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var calculator = new DepthCalculation();
            var newDepth = new Branch
            {
                Branches = new List<Branch>
                {
                    new Branch(new List<Branch> { new Branch(
                        new List<Branch> { new Branch(
                            new List<Branch> { new Branch(
                                new List<Branch> { new Branch(
                                    new List<Branch> { new Branch(
                                        new List<Branch> { new Branch(
                                            new List<Branch> { new Branch() }) }) }) }) }) }) }),

                }
            };

            var result = calculator.DepthCalculator(newDepth.Branches);
            Console.WriteLine($"The depth of this structure is: {result}");
            Console.ReadLine();
        }
    }
}