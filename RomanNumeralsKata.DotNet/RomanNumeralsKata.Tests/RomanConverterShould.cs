using FluentAssertions;
using NUnit.Framework;

namespace RomanNumeralsKata.Tests
{
    public class RomanConverterShould
    {
        [Test]
        public void convert_zero_to_a_empty_string() {
            var converter = new RomanCoverter();

            var romanNumeral = converter.Convert(0);

            romanNumeral.Should().Be(string.Empty);
        }

        [Test]
        public void convert_one_to_I()
        {
            var converter = new RomanCoverter();

            var romanNumeral = converter.Convert(1);

            romanNumeral.Should().Be("I");
        }
    }
}
