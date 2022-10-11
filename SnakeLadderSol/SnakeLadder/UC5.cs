using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadder
{
    internal class UC5
    {
        public const int Nomove = 0;
        public const int Snake = 1;
        public const int Ladder = 2;
        public const int Player1Pos = 0;
        public const int WinningPos = 100;
        public static void RollnStep2()
        {
            int Position = Player1Pos;
            while (Position <= WinningPos)
            {
                Random random = new Random();
                int Dice = random.Next(1, 7);
                Console.Write("Dice roll: " + Dice + "\n");
                Position += Dice;
                int option = random.Next(0, 3);
                switch (option)
                {
                    case Nomove:
                        Position = Position;
                        break;
                    case Snake:
                        Console.Write("Snake Bites\n");
                        Position -= Dice;
                        break;
                    case Ladder:
                        Console.Write("Ladder came\n");
                        Position = Position;
                        break;
                    default:
                        Position = Position;
                        break;
                }
                Console.Write("After dice roll player position is " + Position + "\n");
                if (Position < 0)
                    Position = 0;
                if (Position > WinningPos)
                    Position = Position;
                if (Position == WinningPos)
                {
                    Console.Write("CONGRATULATIONS YOU HAVE WON!!");
                    break;
                }

            }
        }
    }
}
