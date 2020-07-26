using System;
using System.Collections.Generic;

namespace RomanNumerals
{
    public class RomanNumerals
    {
        private static Dictionary<int, string> _mappingIntToRoman = new Dictionary<int, string>()
        {
            {1000, "M"},
            {900, "CM"},
            {500, "D"},
            {400, "CD"},
            {100, "C"},
            {90, "XC"},
            {50, "L"},
            {40, "XL"},
            {10, "X"},
            {9, "IX"},
            {5, "V"},
            {4, "IV"},
            {1, "I"}
        };

        private static Dictionary<string, int> _mappingRomanToInt = new Dictionary<string, int>()
        {
            {"M",1000},
            {"CM",900},
            {"D",500},
            {"CD",400},
            {"C",100},
            {"XC",90},
            {"L",50},
            {"XL",40},
            {"X",10},
            {"IX",9},
            {"V",5},
            {"IV",4},
            {"I",1}
        };

        public static string FromInteger(int number)
        {
            var res = "";
            foreach (var key in _mappingIntToRoman.Keys)
            {
                while (number >= key)
                {
                    res += _mappingIntToRoman[key];
                    number -= key;
                }
            }

            return res;

        }

        public static int ToInteger(string numeral)
        {
            var res = 0;
            while (!string.IsNullOrWhiteSpace(numeral))
            {
                while (!string.IsNullOrWhiteSpace(numeral) && !_mappingRomanToInt.ContainsKey(numeral))
                {
                    foreach (var key in _mappingRomanToInt.Keys)
                    {
                        var index = numeral.IndexOf(key, StringComparison.CurrentCultureIgnoreCase);
                        if (index == 0)
                        {
                            numeral = numeral.Substring(index + key.Length);
                            res += _mappingRomanToInt[key];
                        }
                    }
                }
                res += _mappingRomanToInt.ContainsKey(numeral) ? _mappingRomanToInt[numeral] : 0;
                foreach (var key in _mappingRomanToInt.Keys)
                {
                    var index = numeral.IndexOf(key, StringComparison.CurrentCultureIgnoreCase);
                    if (index >= 0)
                    {
                        numeral = numeral.Substring(index + 1);
                    }
                }
            }

            return res;
        }
    }
}
