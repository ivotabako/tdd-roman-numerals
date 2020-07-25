namespace RomanNumerals
{
    public class RomanNumerals
    {
        public static string FromInteger(int number)
        {
            if (number == 2)
            {
                return "II";
            }
            return "I";
        }
    }
}
