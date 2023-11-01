using FizzBuzz;
using Xunit;

namespace FizzBuzzTest
{
    public class FizzBuzzGameTest
    {
        [Fact]
        public void Should_return_the_given_number_when_countOff_given_a_normal_case()
        {
            //Given
            int givenNumber = 1;
            //When
            string result = FizzBuzzGame.CountOff(givenNumber);
            //Then
            Assert.Equal("1", result);
        }

        [Fact]
        public void Should_return_fizz_when_countOff_given_a_multiple_of_3()
        {
            //Given
            int givenNumber = 9;
            //When
            string result = FizzBuzzGame.CountOff(givenNumber);
            //Then
            Assert.Equal("Fizz", result);
        }

        [Fact]
        public void Should_return_buzz_when_countOff_given_a_multiple_of_5()
        {
            //Given
            int givenNumber = 10;
            //When
            string result = FizzBuzzGame.CountOff(givenNumber);
            //Then
            Assert.Equal("Buzz", result);
        }

        [Fact]
        public void Should_return_fizzbuzz_when_countOff_given_a_multiple_of_5_and_3()
        {
            //Given
            int givenNumber = 15;
            //When
            string result = FizzBuzzGame.CountOff(givenNumber);
            //Then
            Assert.Equal("FizzBuzz", result);
        }
    }
}