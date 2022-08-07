using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipGame
{
    public class ValidatePlace
    {
        public static bool Horizontal(string[,] grid, int startCol, int startRow, int slots)
        {
            bool result;
            int endCol = startCol + slots;
            if (endCol < grid.GetLength(1)) { result = true; } else { return false; }

            for (int i = startCol; i < endCol; i++)
            {
                if (grid[startRow, i] == "~") { result = true; } else { return false; }
            }
            return result;
        }

        public static bool Vertical(string[,] grid, int startCol, int startRow, int slots)
        {
            bool result;
            int endRow = startRow + slots;
            if (endRow < grid.GetLength(0) - 1) { result = true; } else { return false; }

            for (int i = startRow; i < endRow; i++)
            {
                if (grid[i, startCol] == "~") { result = true; } else { return false; }
            }
            return result;
        }
    }
}
