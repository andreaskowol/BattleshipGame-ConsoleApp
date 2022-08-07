using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipGame
{
    internal class GameSet
    {
        public int Rows { get; set; } = 10;
        public int Columns { get; set; } = 10;
        public int[] Ships { get; set; } = { 5, 4, 3, 3, 2 };
        public int HitsToWin { get; set; }
        public int StartRow { get; set; }
        public int StartColumn { get; set; }
        public int Direction { get; set; }
        public int PlayerTurn { get; set; }

        public GameSet()
        {
            HitsToWin = Ships.Sum();
        }

        public List<Player> GeneratePlayers(int numberOfPlayers)
        {
            var players = new List<Player>();
            for (int i = 0; i < numberOfPlayers; i++)
            {
                players.Add(new Player(i));
            }
            return players;
        }

        public static string[,] CreateGrid(int rows, int columns)
        {
            string[,] grid = new string[rows, columns];

            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    grid[i, j] = new string("~");
                }
            }
            return grid;
        }
    }
}
