﻿using FluentAssertions;
using NUnit.Framework;

namespace RomanNumeralsKata.Tests
{
    public class RomanConverterFeature
    {
        [TestCase(1,"I")]
        [TestCase(2,"II")]
        [TestCase(3,"III")]
        [TestCase(4,"IV")]
        [TestCase(5,"V")]
        [TestCase(6,"VI")]
        [TestCase(7,"VII")]
        [TestCase(8, "VIII")]
        [TestCase(9, "IX")]
        public void convert_units(int number, string expectedRomanNumeral) {
            var converter = new RomanCoverter();

            var romanNumeral = converter.Convert(number);

            romanNumeral.Should().Be(expectedRomanNumeral);
        }


    }
}