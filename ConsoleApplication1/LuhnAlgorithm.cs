using System;

namespace CreditCardValidator
{
    public static class LuhnAlgorithm
    {
        public static Boolean IsValidCard(Int64 cardNumber)
        {
            var sum = 0L;
            var isEven = false;

            while (cardNumber > 0)
            {
                var digit = cardNumber % 10;

                if (isEven)
                    digit = CalculateEvenDigit(digit);

                sum += digit;
                cardNumber /= 10;
                isEven = !isEven;
            }

            return sum % 10 == 0;
        }

        private static Int64 CalculateEvenDigit(Int64 digit)
        {
            return (digit * 2) > 9 ? (digit * 2) - 9 : digit * 2;
        }
    }
}
