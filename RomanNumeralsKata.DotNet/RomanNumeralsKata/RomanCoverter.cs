using System.Collections.Generic;
using System.Linq;

namespace RomanNumeralsKata
{
    public class RomanCoverter
    {
        private static readonly Dictionary<int, string> arabicToRomanSymbols = new() {
            {900, "CM"},
            {500, "D"},
            { 400, "CD"},
            { 100, "C"},
            { 90, "XC"},
            { 50, "L"},
            { 40, "XL"},
            { 10, "X"},
            { 9, "IX"},
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
            var (symbolValue, symbol) = arabicToRomanSymbols.First(x => x.Key <= number);
            return (symbolValue, symbol);
        }
    }
}