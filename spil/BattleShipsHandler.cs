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
            battleShipsPlayer1.Place(5);
            battleShipsPlayer1.Shoot();
        }
    }
}