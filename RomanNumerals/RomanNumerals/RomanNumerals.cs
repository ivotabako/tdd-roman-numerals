using System.Collections.Generic;

namespace RomanNumerals
{
    public class RomanNumerals
    {
        private static Dictionary<int, string> _mapping = new Dictionary<int, string>()
        {
            {4, "IV"},
            {1, "I"}
        };

        public static string FromInteger(int number)
        {
            var res = "";
            foreach (var key in _mapping.Keys)
            {
                while (number >= key)
                {
                    res += _mapping[key];
                    number -= key;
                }
            }

            return res;
            //if (number == 4)
            //    return "IV";

            //var res = "";
            //while (number > 0)
            //{
            //    res += "I";
            //    number--;
            //}

            //return res;
        }
    }
}
