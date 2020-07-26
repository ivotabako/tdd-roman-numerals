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
            RomanNumerals.FromInteger(3).Should().Be("III");
            RomanNumerals.FromInteger(4).Should().Be("IV");
            RomanNumerals.FromInteger(5).Should().Be("V");
            RomanNumerals.FromInteger(1981).Should().Be("MCMLXXXI");
        }

        [Test]
        public void FromRomanNumerals()
        {
            RomanNumerals.ToInteger("I").Should().Be(1);
            RomanNumerals.ToInteger("II").Should().Be(2);
            RomanNumerals.ToInteger("III").Should().Be(3);
            RomanNumerals.ToInteger("IV").Should().Be(4);
            RomanNumerals.ToInteger("V").Should().Be(5);
            RomanNumerals.ToInteger("MCMLXXXI").Should().Be(1981);
        }
    }
}