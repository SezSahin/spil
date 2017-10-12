using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spil
{
    class BattleShipsHandler
    {
        internal void start()
        {
            BattleShipsPlayer battleShipsPlayer1 = new BattleShipsPlayer("player1");
            BattleShipsPlayer battleShipsPlayer2 = new BattleShipsPlayer("player2");

            battleShipsPlayer1.Place(5);
            battleShipsPlayer1.Place(4);
            battleShipsPlayer1.Place(3);
            battleShipsPlayer1.Place(3);
            battleShipsPlayer1.Place(2);
            Console.Clear();
            Console.WriteLine("turn the computer to player 2");
            Console.ReadLine();
            battleShipsPlayer2.Place(5);
            battleShipsPlayer2.Place(4);
            battleShipsPlayer2.Place(3);
            battleShipsPlayer2.Place(3);
            battleShipsPlayer2.Place(2);
            Console.Clear();
            Console.WriteLine(" turn the computer to player 1");
            Console.ReadLine();

            while (true)
            {
                battleShipsPlayer2.Shoot(); //player 1 turn
                 if (battleShipsPlayer2.CheckLoss())
                { Console.WriteLine(battleShipsPlayer1.Name + " a winner is you!"); break; }
                Console.Clear();
                Console.WriteLine(" turn the computer to player 2");
                Console.ReadLine();

                battleShipsPlayer1.Shoot(); //player 2 turn
                if (battleShipsPlayer1.CheckLoss())
                { Console.WriteLine(battleShipsPlayer2.Name + " a winner is you!"); break; }
                Console.Clear();
                Console.WriteLine(" turn the computer to player 1");
                Console.ReadLine();
            }
        }
    }
}