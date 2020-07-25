using FluentAssertions;
using NUnit.Framework;

namespace RomanNumerals.Tests
{
    public class RomanNumeralsTests
    {
        [Test]
        public void ToRomanNumerals()
        {
            RomanNumerals.FromInteger(1).Should().Be("I");
            RomanNumerals.FromInteger(2).Should().Be("II");
        }
    }
}