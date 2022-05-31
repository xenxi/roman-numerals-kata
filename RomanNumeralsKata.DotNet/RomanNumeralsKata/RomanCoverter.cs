namespace RomanNumeralsKata
{
    public class RomanCoverter
    {
        public string Convert(int number) {
            if (number == 4)
                return "IV";
            if (number > 0)
                return "I" + Convert(number - 1);

            return string.Empty;
        }
    }
}