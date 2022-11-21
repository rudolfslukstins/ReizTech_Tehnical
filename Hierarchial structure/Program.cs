using System;
using System.Collections.Generic;
using Hierarchial_structure.Model;

namespace Hierarchial_structure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var calculator = new DepthCalculation();
            var newDepth = new Branch
            {
                Branches = new List<Branch>
                {
                    new(new List<Branch>{new()}),
                    new(new List<Branch>{
                        new(),
                        new(new List<Branch>{new()}),
                        new(new List<Branch>{new( 
                            new List<Branch>{new()}), new()})
                    })
                }
            };

            var result = calculator.DepthCalculator(newDepth.Branches);
            Console.WriteLine($"The depth of this structure is: {result}");
        }
    }
}
