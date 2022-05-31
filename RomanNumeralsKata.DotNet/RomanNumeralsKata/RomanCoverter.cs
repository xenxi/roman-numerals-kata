namespace RomanNumeralsKata {
    public class RomanCoverter {
        public string Convert(int number) {
            if (number == 1)
                return "I";
            if (number == 2)
                return "II";
            if (number == 3)
                return "III";
            return string.Empty;
        }
    }
}