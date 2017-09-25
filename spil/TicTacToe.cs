using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spil
{
    public class TicTacToe
    {
        //private bool gameRunning = true;
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
            char resultat = ' ';

            // skriv validerings kode her

            if (gameBoard[0, 0] == 'X' && gameBoard[1, 0] == 'X' && gameBoard[2, 0] == 'X')
            {
                Console.WriteLine("Player 1 wins!\nPress ENTER to end game");
                Console.ReadLine();
                Environment.Exit(0);
            }

            if (gameBoard[0, 1] == 'X' && gameBoard[1, 1] == 'X' && gameBoard[2, 1] == 'X')
            {
                Console.WriteLine("Player 1 wins!\nPress ENTER to end game");
                Console.ReadLine();
                Environment.Exit(0);
            }

            if (gameBoard[0, 2] == 'X' && gameBoard[1, 2] == 'X' && gameBoard[2, 2] == 'X')
            {
                Console.WriteLine("Player 1 wins!\nPress ENTER to end game");
                Console.ReadLine();
                Environment.Exit(0);
            }

            if (gameBoard[0, 0] == 'X' && gameBoard[0, 1] == 'X' && gameBoard[0, 2] == 'X')
            {
                Console.WriteLine("Player 1 wins!\nPress ENTER to end game");
                Console.ReadLine();
                Environment.Exit(0);
            }

            if (gameBoard[1, 0] == 'X' && gameBoard[1, 1] == 'X' && gameBoard[1, 2] == 'X')
            {
                Console.WriteLine("Player 1 wins!\nPress ENTER to end game");
                Console.ReadLine();
                Environment.Exit(0);
            }

            if (gameBoard[2, 0] == 'X' && gameBoard[2, 1] == 'X' && gameBoard[2, 2] == 'X')
            {
                Console.WriteLine("Player 1 wins!\nPress ENTER to end game");
                Console.ReadLine();
                Environment.Exit(0);
            }

            return resultat;
        }

        // her kan implementeres metoder til at sætte og flytte en brik

    }
}
