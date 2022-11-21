using System;
using ClockAngle.ClockAngleTask.Exceptions;
using ClockAngle.ClockAngleTask.Interface;
using ClockAngle.Model;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClockAngle.Tests
{
    [TestClass]
    public class ClockAngleTests
    {
        private ICalculation _calculation;
        [TestInitialize]
        public void Setup()
        {
            _calculation = new Calculation();
        }
        [TestMethod]
        public void CalculateAngle_InputIsCorrectSmallAngle_AnswerShouldBe30()
        {
            var result = _calculation.CalculateDegrees(3, 10);

            result.Should().Be(30);
        }

        [TestMethod]
        public void CalculateAngle_InputIsCorrectLargeAngle_AnswerShouldBe150()
        {
            var result = _calculation.CalculateDegrees(8, 5);

            result.Should().Be(150);
        }


        [TestMethod]
        public void CalculateAngle_InputIsCorrectWithLargeNumber_AnswerShouldBe150()
        {
            var result = _calculation.CalculateDegrees(20, 65);

            result.Should().Be(150);
        }

        [TestMethod]
        public void CalculateAngle_InputIsCorrectWith12Hours_AnswerShouldBe90()
        {
            var result = _calculation.CalculateDegrees(12, 15);

            result.Should().Be(90);
        }

        [TestMethod]
        public void CalculateAngle_InputIsIncorrectWithHours_ShouldThrowInvalidInputException()
        {
            Action act = () => _calculation.CalculateDegrees(-1, 10);
            act.Should().Throw<InvalidInputException>()
                .WithMessage("Invalid input!");
        }

        [TestMethod]
        public void CalculateAngle_InputIsIncorrectWithMinutes_ShouldThrowInvalidInputException()
        {
            Action act = () => _calculation.CalculateDegrees(1, -10);
            act.Should().Throw<InvalidInputException>()
                .WithMessage("Invalid input!");
        }
    }
}