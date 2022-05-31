using System.Collections.Generic;
using System.Linq;

namespace RomanNumeralsKata;

public class Symbols {
    public Symbol FindClosestSymbol(int number) {
        var arabicToRomanSymbols = new List<Symbol>() {
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
        return arabicToRomanSymbols.First(x => x.Arabic <= number);
    }
}