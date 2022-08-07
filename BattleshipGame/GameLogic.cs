using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipGame
{
    public class GameLogic
    {
        public static List<Player> Game(List<Player> _players, int _hitsToWin, int _rows, int _columns)
        {
            while (_players[0].Hits < _hitsToWin && _players[1].Hits < _hitsToWin)
            {
                Random r = new();
                int playerTurn = r.Next(2);
                int rowPos = r.Next(_rows);
                int colPos = r.Next(_columns);
                int owner;
                int opponent;

                if (playerTurn == 0) { owner = 0; opponent = 1; } else { owner = 1; opponent = 0; }

                string hitSign = _players[opponent].Grid[rowPos, colPos];

                switch (hitSign)
                {
                    case "~":
                        _players[opponent].Grid[rowPos, colPos] = "#";
                        _players[owner].Approaches++;
                        playerTurn = playerTurn == 0 ? 1 : 0;
                        break;

                    case "#":
                        break;

                    case "x":
                        break;

                    default:
                        _players[opponent].Grid[rowPos, colPos] = "x";
                        _players[owner].Hits++;
                        break;
                }
            }

            return _players;
        }
    }
}
