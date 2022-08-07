using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipGame
{
    public class PlaceGivenShip
    {
        public static string[,] Horizontal(string[,] grid, int startCol, int startRow, int slots)
        {
            int endCol = startCol + slots;
            for (int i = startCol; i < endCol; i++)
            {
                grid[startRow, i] = slots.ToString();
            }
            return grid;
        }

        public static string[,] Vertical(string[,] grid, int startCol, int startRow, int slots)
        {
            int endRow = startRow + slots;
            for (int i = startRow; i < endRow; i++)
            {
                grid[i, startCol] = slots.ToString();
            }
            return grid;
        }
    }
}
