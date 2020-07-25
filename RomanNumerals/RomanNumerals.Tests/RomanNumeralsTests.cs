using NUnit.Framework;

namespace RomanNumerals.Tests
{
    public class RomanNumeralsTests
    {


        [Test]
        public void ToRomanNumerals()
        {
            Assert.AreEqual(RomanNumerals.FromInteger(1), "I");
        }
    }
}