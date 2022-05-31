namespace RomanNumeralsKata
{
    public class RomanCoverter
    {
        private readonly Symbols _symbols = new();

        public string Convert(int number) {
            if (number < 1) return string.Empty;

            var symbol = _symbols.FindClosestSymbol(number);
            return symbol.Roman + Convert(number - symbol.Arabic);
        }
    }
}