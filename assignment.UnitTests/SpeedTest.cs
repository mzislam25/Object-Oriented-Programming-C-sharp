using assignment;

namespace xUnitTest
{
    public class SpeedTest
    {
        [Fact]
        public void Speed_ToString_ReturnsExpectedResult()
        {
            // Arrange
            Speed speed = new Speed(10);

            // Act
            string result = speed.ToString();

            // Assert
            Assert.Equal("10.00 knots", result);
        }

        [Fact]
        public void Speed_ToString_WithFormatSpecifier_ReturnsExpectedResult()
        {
            // Arrange
            Speed speed = new Speed(10);

            // Act
            string result = speed.ToString("MS");

            // Assert
            Assert.Equal("5.14 m/s", result);
        }

    }
}