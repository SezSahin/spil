﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spil
{
    public class TicTacToe : ITicTacToe
    {
        public bool currentPlayer = true;


        public char[,] GameBoard;
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
            for (int i = 0; i < 3; i++)
            {
                if (gameBoard[0, i] == gameBoard[1, i] && gameBoard[1, i] == gameBoard[2, i] && gameBoard[0, i] != ' ')
                {
                    return gameBoard[0, i];
                }

            }
            for (int i = 0; i < 3; i++)
            {
                if (gameBoard[i, 0] == gameBoard[i, 1] && gameBoard[i, 1] == gameBoard[i, 2] && gameBoard[i, 1] != ' ')
                {
                    return gameBoard[i, 0];
                }

            }
            if (gameBoard[0, 0] == gameBoard[1, 1] && gameBoard[2, 2] == gameBoard[1, 1] && gameBoard[1, 1] != ' ')
                return gameBoard[2, 2];

            if (gameBoard[2, 0] == gameBoard[1, 1] && gameBoard[1, 1] == gameBoard[0, 2] && gameBoard[1, 1] != ' ')
                return gameBoard[2, 2];
            else return ' ';
        }
        public virtual bool Place(int x, int y)
        {
            if (GameBoard[x, y] == 'O' || GameBoard[x, y] == 'X')
            {
                Console.WriteLine("Det er ikke muligt at sætte en brik her");
                Console.WriteLine("Prøv igen");
                //Console.ReadLine();
                Console.Clear();
                return false;
            }
            if (currentPlayer)
            {
                GameBoard[x, y] = 'X';
            }
            else
            {
                GameBoard[x, y] = 'O';
            }
            currentPlayer = !currentPlayer;
            return true;
        }

        public virtual bool Move(int x, int y, int z, int w)
        {
            return false;
        }




    }
}

