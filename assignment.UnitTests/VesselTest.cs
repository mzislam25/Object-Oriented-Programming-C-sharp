using assignment;

namespace xUnitTest
{
    public class VesselTest
    {
        [Fact]
        public void Vessel_ToString_ReturnsExpectedResult()
        {
            // Arrange
            Vessel vessel = new Vessel("Vessel 1", "2020", new Speed(10));

            // Act
            string result = vessel.ToString();

            // Assert
            Assert.Equal("Vessel: Vessel 1", result);
        }
        [Fact]
        public void Vessel_GetVesselInfo_ReturnsExpectedResult()
        {
            // Arrange
            Vessel vessel = new Vessel("Vessel 1", "2020", new Speed(10));

            // Act
            string result = vessel.GetVesselInfo();

            // Assert
            Assert.Equal("Type: Vessel, Name: Vessel 1, Year_Built: 2020, Max_Speed: 10.00 knots", result);
        }

        [Fact]
        public void Ferry_GetVesselInfo_ReturnsExpectedResult()
        {
            // Arrange
            Ferry ferry = new Ferry("Ferry 1", "2020", 200, new Speed(10));

            // Act
            string result = ferry.GetVesselInfo();

            // Assert
            Assert.Equal("Type: Ferry, Name: Ferry 1, Year_Built: 2020, Max_Speed: 10.00 knots, Passengers: 200", result);
        }

        [Fact]
        public void Tugboat_GetVesselInfo_ReturnsExpectedResult()
        {
            // Arrange
            Tugboat tugboat = new Tugboat("Tugboat 1", "2020", 200, new Speed(10));

            // Act
            string result = tugboat.GetVesselInfo();

            // Assert
            Assert.Equal("Type: Tugboat, Name: Tugboat 1, Year_Built: 2020, Max_Speed: 10.00 knots, Max_Force: 200", result);
        }

        [Fact]
        public void Submarine_GetVesselInfo_ReturnsExpectedResult()
        {
            // Arrange
            Submarine submarine = new Submarine("Submarine 1", "2020", 200, new Speed(10));

            // Act
            string result = submarine.GetVesselInfo();

            // Assert
            Assert.Equal("Type: Submarine, Name: Submarine 1, Year_Built: 2020, Max_Speed: 10.00 knots, Max_Depth: 200", result);
        }
    }
}