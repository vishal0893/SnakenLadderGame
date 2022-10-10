using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadder
{
    internal class UC2
    {
        public const int Player1Pos = 0;
        public static void Diceroll()
        {
            Random random = new Random();
            int Dice = random.Next(1, 7);
            Console.Write("Dice roll: " + Dice + "\n");
        }
    }
}
