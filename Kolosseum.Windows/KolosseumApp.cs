using Stride.Engine;

namespace Kolosseum
{
    class KolosseumApp
    {
        static void Main(string[] args)
        {
            using (var game = new Game())
            {
                game.Run();
            }
        }
    }
}
