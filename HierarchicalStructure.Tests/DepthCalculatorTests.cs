using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Hierarchial_structure.Model;

namespace HierarchicalStructure.Tests
{
    public class DepthCalculatorTests
    {
        [TestClass]
        public class UnitTest1
        {
            public DepthCalculation DepthCalculator;

            [TestInitialize]
            public void Setup()
            {
                DepthCalculator = new DepthCalculation();
            }

            [TestMethod]
            public void CalculateDepth_CalculateDepthWithTwoLevels_ShouldReturn2()
            {
                var branchList = new List<Branch> { new() };

                DepthCalculator.DepthCalculator(branchList).Should().Be(2);
            }

            [TestMethod]
            public void CalculateDepth_CalculateDepthWithTwoLevels_ShouldReturn5()
            {
                var branchList = new List<Branch>
                {
                    new(new List<Branch>
                    {
                        new(new List<Branch>
                        {
                            new(new List<Branch>
                            {
                                new()
                            })
                        })
                    })
                };

                DepthCalculator.DepthCalculator(branchList).Should().Be(5);
            }


            [TestMethod]
            public void CalculateDepth_NoBranches_ShouldReturnInvalidBuildException()
            {
                var branchList = new List<Branch>();

                Action act = () => DepthCalculator.DepthCalculator(branchList);
                act.Should().Throw<System.InvalidOperationException>()
                    .WithMessage("Sequence contains no elements");
            }
        }
    }
}