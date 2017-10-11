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

            battleShipsPlayer1.Place(); // place the ships for player1, then player2
            battleShipsPlayer2.Place();

            while (true)
            {
                battleShipsPlayer2.Shoot(); //player 1 turn
                battleShipsPlayer2.CheckLoss();

                battleShipsPlayer1.Shoot(); //player 2 turn
                battleShipsPlayer1.CheckLoss(); //needs to do something with loss condition
            }
        }
    }
}