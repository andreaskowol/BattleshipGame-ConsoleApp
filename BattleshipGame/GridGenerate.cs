using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipGame
{
    public class GridGenerate
    {
        public static void InitPlayersGrid(List<Player> players, int rows, int cols, int[] ships)
        {
            for (int i = 0; i < players.Count; i++)
            {
                var grid = GameSet.CreateGrid(rows, cols);
                foreach (int ship in ships)
                {
                    grid = GridPrepare.PlaceShips(grid, rows, cols, ship);
                }
                players[i].Grid = grid;
                Console.WriteLine($"Player {(players[i].Id + 1)} grid:");
                players[i].PrintGrid();
                Console.WriteLine("-----");
                Console.WriteLine();
            }
        }
    }
}
