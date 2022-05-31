using System.Collections.Generic;
using System.Linq;

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
            var closestSymbol = arabicToRomanSymbols.FirstOrDefault(x => x.Key <= number);
            if (number >= 1)
                return closestSymbol.Value + Convert(number - closestSymbol.Key);

            return string.Empty;
        }
    }
}