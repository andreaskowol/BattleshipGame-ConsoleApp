using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipGame
{
    public class GameLogic
    {
        public static List<Player> Game(List<Player> players, int hitsToWin, int rows, int columns)
        {
            while (players[0].Hits < hitsToWin && players[1].Hits < hitsToWin)
            {
                Random r = new();
                int playerTurn = r.Next(2);
                int rowPos = r.Next(rows);
                int colPos = r.Next(columns);
                int owner;
                int opponent;

                if (playerTurn == 0) { owner = 0; opponent = 1; } else { owner = 1; opponent = 0; }

                string hitSign = players[opponent].Grid[rowPos, colPos];

                switch (hitSign)
                {
                    case "~":
                        players[opponent].Grid[rowPos, colPos] = "#";
                        players[owner].Approaches++;
                        playerTurn = playerTurn == 0 ? 1 : 0;
                        break;

                    case "#":
                        break;

                    case "x":
                        break;

                    default:
                        players[opponent].Grid[rowPos, colPos] = "x";
                        players[owner].Hits++;
                        break;
                }
            }
            return players;
        }
    }
}
