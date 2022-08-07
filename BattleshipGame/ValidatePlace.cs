using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipGame
{
    public class ValidatePlace
    {
        public static bool Horizontal(string[,] _grid, int _startCol, int _startRow, int _slots)
        {
            bool result;
            int endCol = _startCol + _slots;
            if (endCol < _grid.GetLength(1)) { result = true; } else { return false; }

            for (int i = _startCol; i < endCol; i++)
            {
                if (_grid[_startRow, i] == "~") { result = true; } else { return false; }
            }

            return result;
        }

        public static bool Vertical(string[,] _grid, int _startCol, int _startRow, int _slots)
        {
            bool result;
            int endRow = _startRow + _slots;
            if (endRow < _grid.GetLength(0) - 1) { result = true; } else { return false; }

            for (int i = _startRow; i < endRow; i++)
            {
                if (_grid[i, _startCol] == "~") { result = true; } else { return false; }
            }

            return result;
        }
    }
}
