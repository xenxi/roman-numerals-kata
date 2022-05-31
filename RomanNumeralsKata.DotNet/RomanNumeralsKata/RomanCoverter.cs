using System.Collections.Generic;
using System.Linq;

namespace RomanNumeralsKata
{
    public class RomanCoverter
    {
        public static readonly List<Symbol> arabicToRomanSymbols = new() {
            new Symbol(900, "CM"),
            new Symbol(500, "D"),
            new Symbol( 400, "CD"),
            new Symbol( 100, "C"),
            new Symbol( 90, "XC"),
            new Symbol( 50, "L"),
            new Symbol( 40, "XL"),
            new Symbol( 10, "X"),
            new Symbol( 9, "IX"),
            new Symbol(5, "V"),
            new Symbol(4, "IV"),
            new Symbol(1, "I"),
        };
        public string Convert(int number) {
            if (number < 1) return string.Empty;

            var symbol = new Symbols().FindClosestSymbol(number);
            return symbol.Roman + Convert(number - symbol.Arabic);
        }
    }
}