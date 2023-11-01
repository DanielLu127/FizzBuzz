using System;

namespace FizzBuzz
{
    public class FizzBuzzGame
    {
        public static string CountOff(int givenNumber)
        {
            if (givenNumber % 3 == 0)
            {
                return "Fizz";
            }
            else if (givenNumber % 5 == 0)
            {
                return "Buzz";
            }
            else
            {
                return givenNumber.ToString();
            }
        }
    }
}
