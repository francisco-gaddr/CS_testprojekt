using Xunit;
using CS_testprojekt.Dice;

using Xunit.Abstractions;

namespace CS_testprojekt
{
    public class DiceTests
    {

        private readonly ITestOutputHelper _output;

        public DiceTests(ITestOutputHelper output)
        {
            _output = output;

        }
        [Fact]
      
        public void ThrowDiceRangeTest()
        {
            // Arrange
            bool result= false;

            // Act
            int actual = Dice.Dice.trowDice(1,6);

            _output.WriteLine(actual.ToString());

            if (actual <= 6 && actual >= 1)
                result = true;

         
            // Assert
            Assert.True(result);

        }


        [Fact]
        public void MultiplyTest()
        {

            // Arrange
            var calc = new Calculator();
            int expected = 6;

            // Act
            var actual = calc.Multiply(3, 2);


            // Assert
            Assert.Equal(expected, actual);


        }
    }
}