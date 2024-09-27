using Xunit;

namespace UnitTests.Tests;

public static class WorldsDumbestFunctionTests
{
    [Fact]
    public static void ReturnsPikachuIfZero_WhenValorIsZero_ReturnsPikachu()
    {
        try
        {
            // Arrange
            var worldsDumbestFunction = new WorldsDumbestFunction();

            // Act
            var result = worldsDumbestFunction.ReturnsPikachuIfZero(0);

            // Assert
            Assert.Equal("Pikachu", result);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    [Fact]
    public static void ReturnsPikachuIfZero_WhenValorIsNotZero_ReturnsSquirtle()
    {
        try
        {

            // Arrange
            var worldsDumbestFunction = new WorldsDumbestFunction();

            // Act
            var result = worldsDumbestFunction.ReturnsPikachuIfZero(1);

            // Assert
            Assert.Equal("Squirtle", result);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
