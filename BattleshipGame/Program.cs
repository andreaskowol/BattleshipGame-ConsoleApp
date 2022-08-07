namespace BattleshipGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // Game rules init
            GameSet gameSet = new();

            // Players init
            var players = gameSet.GeneratePlayers(2);

            // Generate grid with ships locations for each player
            GridGenerate.InitPlayersGrid(players, gameSet.Rows, gameSet.Columns, gameSet.Ships);

            // Game simulation
            players = GameLogic.Game(players, gameSet.HitsToWin, gameSet.Rows, gameSet.Columns);

            // Print results
            Results.PrintResult(players);

            Console.ReadLine();
        }
    }
}
