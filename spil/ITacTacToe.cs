using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spil
{
    interface ITicTacToe
    {
        bool Place(Array[,] array);
        bool CheckWin();
        string GetGameBoardView();

    }
}
