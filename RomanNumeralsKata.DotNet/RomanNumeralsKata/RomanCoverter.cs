namespace RomanNumeralsKata
{
    public class RomanCoverter
    {
        public string Convert(int number) {
            if (number == 5)
                return "V" + Convert(0);
            if (number == 4)
                return "IV" + Convert(0);
            if (number > 0)
                return "I" + Convert(number - 1);

            return string.Empty;
        }
    }
}