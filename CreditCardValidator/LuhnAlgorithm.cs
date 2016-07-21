using System;

namespace CreditCardValidator
{
    public class LuhnAlgorithm
    {
        public Boolean IsValidCard(Int32 cardNumber)
        {
            var sum = 0;
            var isEven = false;

            cardNumber /= 10;

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

        private Int32 CalculateEvenDigit(Int32 digit)
        {
            return digit * 2 > 9 ? digit * 2 - 9 : digit * 2;
        }
    }
}
