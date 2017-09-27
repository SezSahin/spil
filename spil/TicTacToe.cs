using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spil 
{
    public class TicTacToe : ITicTacToe
    {
        private bool gameRunning = true;
        private bool currentPlayer = true;
        //private string input;
        //private playerOne, playerTwo;

        public char[,] GameBoard { get; set; }
        public TicTacToe()
        {
            GameBoard = new char[3, 3] 
            { 
                {' ', ' ', ' '},
                {' ', ' ', ' '}, 
                {' ', ' ', ' '}
            };
            gameRunning = true;
        }

        public string GetGameBoardView()
        {
            string resultat = "";
            resultat = resultat + "Y\n";
            resultat = resultat + "  *******************\n";
            resultat = resultat + "  *     *     *     *\n";
            resultat = resultat + "3 *  " + GameBoard[0, 2] + "  *  " + GameBoard[1, 2] + "  *  " + GameBoard[2, 2] + "  *\n";
            resultat = resultat + "  *     *     *     *\n";
            resultat = resultat + "  *******************\n";
            resultat = resultat + "  *     *     *     *\n";
            resultat = resultat + "2 *  " + GameBoard[0, 1] + "  *  " + GameBoard[1, 1] + "  *  " + GameBoard[2, 1] + "  *\n";
            resultat = resultat + "  *     *     *     *\n";
            resultat = resultat + "  *******************\n";
            resultat = resultat + "  *     *     *     *\n";
            resultat = resultat + "1 *  " + GameBoard[0, 0] + "  *  " + GameBoard[1, 0] + "  *  " + GameBoard[2, 0] + "  *\n";
            resultat = resultat + "  *     *     *     *\n";
            resultat = resultat + "  *******************\n";
            resultat = resultat + "     1     2     3    X\n";

            return resultat;
        }


        public static char Validate(char[,] gameBoard)
        {
               for(int i = 0; i < 3; i++)
            {
                if (gameBoard[0, i] == gameBoard[1,i] && gameBoard[1, i] == gameBoard[2,i])
                {
                    return gameBoard[0, i];
                }

            }
            for (int i = 0; i < 3; i++)
            {
                if (gameBoard[i, 0] == gameBoard[i, 1] && gameBoard[i, i] == gameBoard[i, 2])
                {
                    return gameBoard[i, 0];
                }

            }
            if (gameBoard[1, 1] == gameBoard[2, 2] && gameBoard[2, 2] == gameBoard[3, 3])
                return gameBoard[2, 2];

            if (gameBoard[1, 3] == gameBoard[2, 2] && gameBoard[2, 2] == gameBoard[3, 1])
                return gameBoard[2, 2];
            else return ' ';
        }
        public bool Place(int x, int y)
        {
            if (currentPlayer)
            {

                GameBoard[x, y] = 'X';
            }
            else
            {
                GameBoard[x, y] = 'O';
            }
            GetGameBoardView();
            currentPlayer = !currentPlayer;
            return true;
        }



        // her kan implementeres metoder til at sætte og flytte en brik

    }
}
