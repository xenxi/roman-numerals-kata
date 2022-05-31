namespace RomanNumeralsKata
{
    public class RomanCoverter
    {
        public string Convert(int number) {
            if (number >= 5)
                return "V" + Convert(number - 5);
            if (number >= 4)
                return "IV" + Convert(number - 4);
            if (number >= 1)
                return "I" + Convert(number - 1);

            return string.Empty;
        }
    }
}