using System;
using System.Text;

namespace Code
{
    public class RomanNumbersTestRepresentation
    {
        public const string ROMAN_NUMBER_HAS_NO_ZERO = "No existe representacion del 0 en numeros romanoa";

        public string of(int aNumber)
        {
            if (aNumber == 0)
                throw new Exception(ROMAN_NUMBER_HAS_NO_ZERO);

            StringBuilder aStringBuilder = new StringBuilder();
            int units = aNumber % 10;
            int tens = (aNumber/10) % 10;
            int hundreds = (aNumber / 100) % 10;
            int miles = (aNumber / 1000) % 10;

            ConvertDigitUsing(miles, aStringBuilder, "M", "V", "X");
            ConvertDigitUsing(hundreds, aStringBuilder, "C", "D", "M");
            ConvertDigitUsing(tens, aStringBuilder, "X", "L", "C");
            ConvertDigitUsing(units, aStringBuilder, "I", "V", "X");

            return aStringBuilder.ToString();
        }

        private static void ConvertDigitUsing(int aNumber, StringBuilder aStringBuilder, string asOne, string asFive, string asTen)
        {
            if (aNumber >= 1 && aNumber <= 3)
            {
                for (int i = 1; i <= aNumber; ++i)
                {
                    aStringBuilder.Append(asOne);
                }
            }

            if (aNumber == 4) 
            {
                aStringBuilder.Append(asOne).Append(asFive);
            }
                

            if (aNumber >= 5 && aNumber <= 8)
            {
                aStringBuilder.Append(asFive);
                for (int i = 1; i <= aNumber - 5; ++i)
                {
                    aStringBuilder.Append(asOne);
                }
            }

            if (aNumber == 9) 
            {
                aStringBuilder.Append(asOne).Append(asTen);
            }
                
        }
    }
}
