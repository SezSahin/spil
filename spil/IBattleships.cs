using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spil
{
    interface IBattleShips
    {
        bool Shoot(int x, int y);
        string GetGameBoardView();
        string GetRadarWiew();
        bool Place(int shipLength);
        object CheckLoss();
    }
}
