using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipGame
{
    public class Results
    {
        public static void PrintResult(List<Player> playerList)
        {
            Console.WriteLine();
            Console.WriteLine("!WINNER! is: " + (playerList[0].Hits > playerList[1].Hits ? "Player 1" : "Player 2"));
            Console.WriteLine();

            Console.WriteLine($"Player 1 with {playerList[0].Hits} hits. Grid:");
            playerList[0].PrintGrid();
            Console.WriteLine();

            Console.WriteLine($"Player 2 with {playerList[1].Hits} hits. Grid:");
            playerList[1].PrintGrid();
        }
    }
}
