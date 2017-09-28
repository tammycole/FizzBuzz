using System;
using NUnit.Framework;

namespace FizzBuzz
{

    [TestFixture]
    public class FizzBuzzTest
    {
       
        [Test]
        public void MultipleOfThree()
        {
            bool expected = false;
            bool actual = FizzBuzz.DivThree(4);
            Assert.AreEqual(expected, actual, "You failed the three test - Fail condition ==true");
        }

        [Test]
        public void MultipleOfFive()
        {
            bool expected = false;
            bool actual = FizzBuzz.DivThree(4);
            Assert.AreEqual(expected, actual, "You failed the five test - Fail condition ==true");
        }

        [Test]
        public void WordReturn()
        {
            string expected = "Fizz";
            string actual = FizzBuzz.PrintString(true, false, false);
            Assert.AreEqual(expected, actual, "Condition for THREE returned False");

            expected = "Buzz";
            actual = FizzBuzz.PrintString(false, true, false);
            Assert.AreEqual(expected, actual, "Condition for FIVE returned False");

            expected = "FizzBuzz";
            actual = FizzBuzz.PrintString(false, false, true);
            Assert.AreEqual(expected, actual, "Condition for THREEFIVE returned False");

            expected = "Fizz";
            actual = FizzBuzz.PrintString(true, true, true);
            Assert.AreEqual(expected, actual, "Check this out something went wrong");
        }
    }
}
