using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipGame
{
    public class PlaceGivenShip
    {
        public static string[,] Horizontal(string[,] _grid, int _startCol, int _startRow, int _slots)
        {
            int endCol = _startCol + _slots;
            for (int i = _startCol; i < endCol; i++)
            {
                _grid[_startRow, i] = _slots.ToString();
            }

            return _grid;
        }

        public static string[,] Vertical(string[,] _grid, int _startCol, int _startRow, int _slots)
        {
            int endRow = _startRow + _slots;
            for (int i = _startRow; i < endRow; i++)
            {
                _grid[i, _startCol] = _slots.ToString();
            }

            return _grid;
        }
    }
}
