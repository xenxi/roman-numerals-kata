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
            if (number < 1) return string.Empty;

            var (symbolValue, symbol) = FindClosestSymbol(number);
            return symbol + Convert(number - symbolValue);
        }

        private static (int symbolValue, string symbol) FindClosestSymbol(int number) {
            var (symbolValue, symbol) = arabicToRomanSymbols.FirstOrDefault(x => x.Key <= number);
            return (symbolValue, symbol);
        }
    }
}