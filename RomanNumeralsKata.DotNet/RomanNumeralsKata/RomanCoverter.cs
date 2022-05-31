using System.Collections.Generic;

namespace RomanNumeralsKata
{
    public class RomanCoverter
    {
        private static readonly Dictionary<int, string> arabicToRomanSymbols = new() {
            {5, "V"},
            {4, "IV"},
            {1, "I"},
        };
        public string Convert(int number) {
            if (number >= 5)
                return arabicToRomanSymbols[5] + Convert(number - 5);
            if (number >= 4)
                return arabicToRomanSymbols[4] + Convert(number - 4);
            if (number >= 1)
                return arabicToRomanSymbols[1] + Convert(number - 1);

            return string.Empty;
        }
    }
}