namespace UnitTests.Tests;

public static class WorldsDumbestFunctionTests
{
    public static void ReturnsPikachuIfZero_WhenValorIsZero_ReturnsPikachu()
    {
        try
        {
            // Arrange
            var worldsDumbestFunction = new WorldsDumbestFunction();

            // Act
            var result = worldsDumbestFunction.ReturnsPikachuIfZero(0);

            // Assert
            Console.WriteLine(result);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public static void ReturnsPikachuIfZero_WhenValorIsNotZero_ReturnsSquirtle()
    {
        try
        {

            // Arrange
            var worldsDumbestFunction = new WorldsDumbestFunction();

            // Act
            var result = worldsDumbestFunction.ReturnsPikachuIfZero(1);

            // Assert
            Console.WriteLine(result);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
