using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipGame
{
    public class GridPrepare
    {
        public static string[,] PlaceShips(string[,] grid, int rows, int columns, int slots)
        {
            Random r = new();
            bool result = false;
            int startRow = 0;
            int startCol = 0;
            int direction = 0;

            // Check if generated numbers for potential ship place are valid? place ship on those numbers : generate new number
            while (!result)
            {
                startRow = r.Next(rows);
                startCol = r.Next(columns);
                direction = r.Next(2);

                if (direction == 0) { result = ValidatePlace.Horizontal(grid, startCol, startRow, slots); }

                if (direction == 1) { result = ValidatePlace.Vertical(grid, startCol, startRow, slots); }
            }

            if (direction == 0) { grid = PlaceGivenShip.Horizontal(grid, startCol, startRow, slots); }

            if (direction == 1) { grid = PlaceGivenShip.Vertical(grid, startCol, startRow, slots); }

            return grid;
        }
    }
}
