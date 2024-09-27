using FluentAssertions;
using NetworkUtility.Ping;

namespace NetworkUtility.Tests
{
    public class NetworkServiceTests
    {
        [Fact]
        public void SendPing_WhenCalled_ReturnsPingingMessage()
        {
            // Arrange
            var networkService = new NetworkService();
            var address = "www.google.com";
            var expected = $"Success: Pinging... {address}";

            // Act
            var result = networkService.SendPing(address);

            // Assert
            result.Should().NotBeNullOrWhiteSpace();
            result.Should().Be(expected);
            result.Should().Contain("Success", Exactly.Once());
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(2, 3, 5)]
        public void GetPingTimeOut_WhenCalled_ReturnsSumOfTwoNumbers(int a, int b, int expected)
        {
            // Arrange
            var networkService = new NetworkService();

            // Act
            var result = networkService.GetPingTimeOut(a, b);

            // Assert
            result.Should().Be(expected);
            result.Should().BeGreaterThanOrEqualTo(2);
            result.Should().NotBeInRange(-10000, 0);
        }

    }
}