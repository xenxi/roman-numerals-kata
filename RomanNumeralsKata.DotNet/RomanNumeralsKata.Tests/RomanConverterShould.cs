using FluentAssertions;
using NUnit.Framework;

namespace RomanNumeralsKata.Tests
{
    public class RomanConverterShould
    {
        [TestCase(1, "I")]
        [TestCase(2, "II")]
        [TestCase(3, "III")]
        [TestCase(4, "IV")]
        [TestCase(5, "V")]
        [TestCase(9, "IX")]
        [TestCase(10, "X")]
        [TestCase(40, "XL")]
        public void convert_number(int number, string expectedSymbol)
        {
            var converter = new RomanCoverter();

            var romanNumeral = converter.Convert(number);

            romanNumeral.Should().Be(expectedSymbol);
        }
    }
}
