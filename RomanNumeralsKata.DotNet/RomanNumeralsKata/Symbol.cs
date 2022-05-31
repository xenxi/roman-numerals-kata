namespace RomanNumeralsKata;

public class Symbol {
    public Symbol(int arabic, string roman) {
        Arabic = arabic;
        Roman = roman;
    }
    public int Arabic { get; }
    public string Roman { get; }
}