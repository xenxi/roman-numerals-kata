namespace RomanNumeralsKata {
    public class RomanCoverter {
        public string Convert(int number) {
            if (number == 1)
                return "I" + Convert(0);
            if (number == 2)
                return "I" + Convert(1);
            if (number == 3)
                return "I" + Convert(2);
            return string.Empty;
        }
    }
}