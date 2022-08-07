using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipGame
{
    public class GridPrepare
    {
        public static string[,] PlaceShips(string[,] _grid, int _rows, int _columns, int _slots)
        {
            Random r = new();
            bool result = false;
            int startRow = 0;
            int startCol = 0;
            int direction = 0;

            // Check if generated numbers for potential ship place are valid? place ship on those numbers : generate new number
            while (!result)
            {
                startRow = r.Next(_rows);
                startCol = r.Next(_columns);
                direction = r.Next(2);

                if (direction == 0)
                {
                    result = ValidatePlace.Horizontal(_grid, startCol, startRow, _slots);
                }

                if (direction == 1)
                {
                    result = ValidatePlace.Vertical(_grid, startCol, startRow, _slots);
                }
            }

            if (direction == 0)
            {
                _grid = PlaceGivenShip.Horizontal(_grid, startCol, startRow, _slots);
            }

            if (direction == 1)
            {
                _grid = PlaceGivenShip.Vertical(_grid, startCol, startRow, _slots);
            }

            return _grid;
        }
    }
}
