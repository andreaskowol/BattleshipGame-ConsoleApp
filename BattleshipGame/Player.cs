using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipGame
{
    public class Player
    {
        public int Id { get; set; }
        public int Hits { get; set; }
        public int Approaches { get; set; }
        public string[,] Grid { get; set; }


        public Player(int id)
        {
            this.Id = id;
        }


        public void PrintGrid()
        {
            int[] arr = Enumerable.Range(0, Grid.GetLength(1)).ToArray();
            Console.Write("  ");
            foreach (int i in arr)
            {
                Console.Write(i.ToString());
            }
            Console.Write("\n");

            for (int i = 0; i < Grid.GetLength(1); i++)
            {
                Console.Write(i + " ");
                for (int j = 0; j < Grid.GetLength(0); j++)
                {
                    Console.Write(Grid[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
