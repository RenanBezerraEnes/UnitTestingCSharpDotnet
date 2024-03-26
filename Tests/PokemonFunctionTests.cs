using UnitTests;

namespace PokemonFunctionTests.Tests
{
    public static class PokemonFunctionTests
    {
        public static void PokemonFunction_ReturnsPikachuIfZero_ReturnString()
        {
            try
            {
                // Arrange
                int num = 0;

                // Act
                string result = PokemonFunction.ReturnsPikachuIfZero(num);

                // Assert
                if(result == "Pikachu")
                {
                    Console.WriteLine("PASSED: PokemonFunction_ReturnsPikachuIfZero_ReturnString");
                }
                else
                {
                    Console.WriteLine("FAILED: PokemonFunction_ReturnsPikachuIfZero_ReturnString");
                }
            }
            catch (Exception x)
            {
                Console.WriteLine(x);
            }
        }
    }
}