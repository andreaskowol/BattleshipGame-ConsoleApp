using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipGame
{
    public class GridGenerate
    {
        public static void InitPlayersGrid(List<Player> _players, int _rows, int _cols, int[] _ships)
        {

            for (int i = 0; i < _players.Count; i++)
            {
                var grid = GameSet.CreateGrid(_rows, _cols);
                foreach (int ship in _ships)
                {
                    grid = GridPrepare.PlaceShips(grid, _rows, _cols, ship);
                }
                _players[i].Grid = grid;
                Console.WriteLine($"Player {(_players[i].Id + 1)} grid:");
                _players[i].PrintGrid();
                Console.WriteLine("-----");
                Console.WriteLine();
            }
        }
    }
}
