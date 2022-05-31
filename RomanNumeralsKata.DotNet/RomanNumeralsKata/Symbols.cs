using System.Linq;

namespace RomanNumeralsKata;

public class Symbols {
    public Symbol FindClosestSymbol(int number) {
        return RomanCoverter.arabicToRomanSymbols.First(x => x.Arabic <= number);
    }
}