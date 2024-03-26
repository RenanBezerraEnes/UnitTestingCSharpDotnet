namespace UnitTests
{
    public class PokemonFunction
    {
        public static string ReturnsPikachuIfZero(int num)
        {
            if (num == 0)
            {
                return "Pikachu";
            }
            else
            {
                return "Squirtle";
            }
        }
    }
}