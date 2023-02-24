using System;
using System.Collections.Generic;

namespace RomanNumbersCalculator.Models
{
    internal class RomanNumber : IComparable, ICloneable
    {
        ushort num = 1;

        string romNum = "";
        public RomanNumber(ushort numArg)
        {
            if (numArg <= 0 || numArg >= 3999) throw new RomanNumberException("#ERROR");

            this.num = numArg;
            string rom = "";
            string[] one = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
            string[] ten = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] hundred = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            string[] thousand = { "", "M", "MM", "MMM" };
           
            rom += thousand[(numArg / 1000) % 10];
            rom += hundred[(numArg / 100) % 10];
            rom += ten[(numArg / 10) % 10];
            rom += one[numArg % 10];

            romNum = rom;
        }

        public RomanNumber(string number)
        {

            romNum = number;

            Dictionary<char, ushort> match = new Dictionary<char, ushort> { {'I', 1 },{'V', 5 }, {'X', 10 }, {'L', 50 }, {'C', 100 }, {'D', 500 }, {'M', 1000 }};
            if (number.Length == 1) this.num = match[number[0]];
            else
            {
                ushort result = 0, i = 0;
                while (i < number.Length - 1)
                {
                    if (match[number[i]] < match[number[i + 1]])
                    {
                        result += (ushort)(match[number[i + 1]] - match[number[i]]);
                        i += 2;
                    }
                    else
                    {
                        result += match[number[i]];
                        i++;
                        if (i == number.Length - 1)
                            result += match[number[i]];
                    }
                }
                this.num = result;
            }
            if (number != new RomanNumber(this.num).ToString()) throw new RomanNumberException("#ERROR");
            if (this.num < 1 || this.num > 3999) throw new RomanNumberException("#ERROR");
        }

        public static RomanNumber Add(RomanNumber RomanNumber1, RomanNumber RomanNumber2)
        {
            return new RomanNumber((ushort)(RomanNumber1.num + RomanNumber2.num));
        }
        public static RomanNumber Sub(RomanNumber RomanNumber1, RomanNumber RomanNumber2)
        {
            return new RomanNumber((ushort)(RomanNumber1.num - RomanNumber2.num));
        }
        public static RomanNumber Mul(RomanNumber RomanNumber1, RomanNumber RomanNumber2)
        {
            return new RomanNumber((ushort)(RomanNumber1.num * RomanNumber2.num));
        }
        public static RomanNumber Div(RomanNumber RomanNumber1, RomanNumber RomanNumber2)
        {
            return new RomanNumber((ushort)(RomanNumber1.num / RomanNumber2.num));

        }

        public int CompareTo(object? obj)
        {
            if (obj is RomanNumber num) return this.num.CompareTo(num.num);
            else throw new ArgumentException("Can't compare this parametr");
        }

        public object Clone() => MemberwiseClone();

        public override string ToString() => romNum;

        public ushort ToUInt() => num;

    }
}