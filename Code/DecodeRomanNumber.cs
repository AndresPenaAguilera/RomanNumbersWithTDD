using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code
{
    public class DecodeRomanNumber
    { 
       
        public static int of(string roman)
        {
             int number = 0;

        Dictionary<string, int> numbers = new Dictionary<string, int>()
            {
                { "I", 1},
                { "V", 5},
                { "X", 10},
                { "L", 50},
                { "C", 100},
                { "D", 500},
                { "M", 1000},
            };

            int oldValue = 0;

            for (int i = 0; i < roman.Length; i++)
            {
                int value;
                numbers.TryGetValue(roman.Substring(i, 1), out value);

                if (oldValue >= value)
                {
                    number += value;
                }
                else
                {
                    number = (number - oldValue) + (value - oldValue);
                }

                oldValue = value;
            }

            return number;

        }
    }
}
