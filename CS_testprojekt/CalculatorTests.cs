using Xunit;

namespace CS_testprojekt
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData(65, 5, 70, "tja")]
        [InlineData(5, 5, 10, "tja")]
        public void AdditionTest(int valueA, int valueB, int expected, string e)
        {
            // Arrange
            var calc = new Calculator();

            // Act
            var actual = calc.Add(valueA, valueB);

         
            // Assert
            Assert.Equal(expected, actual);

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