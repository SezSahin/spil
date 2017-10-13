using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spil
{
    class BattleShipsPlayer : IBattleShips
    {
        public string Name;
        public char[,] GameBoard;
        private char[,] radar;
        public bool currentPlayer = true;

        public BattleShipsPlayer(string name)
        {
            this.Name = name;
            // H is Hit
            // M is Miss
            // S is Ship
            GameBoard = new char[10, 10]
            {
                {' ',' ',' ',' ',' ',' ',' ',' ',' ',' '},
                {' ',' ',' ',' ',' ',' ',' ',' ',' ',' '},
                {' ',' ',' ',' ',' ',' ',' ',' ',' ',' '},
                {' ',' ',' ',' ',' ',' ',' ',' ',' ',' '},
                {' ',' ',' ',' ',' ',' ',' ',' ',' ',' '},
                {' ',' ',' ',' ',' ',' ',' ',' ',' ',' '},
                {' ',' ',' ',' ',' ',' ',' ',' ',' ',' '},
                {' ',' ',' ',' ',' ',' ',' ',' ',' ',' '},
                {' ',' ',' ',' ',' ',' ',' ',' ',' ',' '},
                {' ',' ',' ',' ',' ',' ',' ',' ',' ',' '}
            };
            radar = new char[10, 10]
            {
                {' ',' ',' ',' ',' ',' ',' ',' ',' ',' '},
                {' ',' ',' ',' ',' ',' ',' ',' ',' ',' '},
                {' ',' ',' ',' ',' ',' ',' ',' ',' ',' '},
                {' ',' ',' ',' ',' ',' ',' ',' ',' ',' '},
                {' ',' ',' ',' ',' ',' ',' ',' ',' ',' '},
                {' ',' ',' ',' ',' ',' ',' ',' ',' ',' '},
                {' ',' ',' ',' ',' ',' ',' ',' ',' ',' '},
                {' ',' ',' ',' ',' ',' ',' ',' ',' ',' '},
                {' ',' ',' ',' ',' ',' ',' ',' ',' ',' '},
                {' ',' ',' ',' ',' ',' ',' ',' ',' ',' '}
            };
        }

        public bool CheckLoss()
        {
            foreach (char slot in GameBoard)
            {
                if (slot == 'S') return false;
            }
            return true;
        }

        public string GetGameBoardView()
        {
            string resultat = "";
            resultat = resultat + "Y\n";
            resultat = resultat + "  *********************************************************\n";

            resultat = resultat + "A * " + GameBoard[0, 0] + "  *" + GameBoard[0, 1] + "    *" + GameBoard[0, 2] + "    *" + GameBoard[0, 3] + "   *" + GameBoard[0, 4] + "    *" + GameBoard[0, 5] + "    *" + GameBoard[0, 6] + "   *" + GameBoard[0, 7] + "    *" + GameBoard[0, 8] + "    *" + GameBoard[0, 9] + "   *\n";

            resultat = resultat + "  *********************************************************\n";

            resultat = resultat + "B * " + GameBoard[1, 0] + "  *" + GameBoard[1, 1] + "    *" + GameBoard[1, 2] + "    *" + GameBoard[1, 3] + "   *" + GameBoard[1, 4] + "    *" + GameBoard[1, 5] + "    *" + GameBoard[1, 6] + "   *" + GameBoard[1, 7] + "    *" + GameBoard[1, 8] + "    *" + GameBoard[1, 9] + "   *\n";

            resultat = resultat + "  *********************************************************\n";

            resultat = resultat + "C * " + GameBoard[2, 0] + "  *" + GameBoard[2, 1] + "    *" + GameBoard[2, 2] + "    *" + GameBoard[2, 3] + "   *" + GameBoard[2, 4] + "    *" + GameBoard[2, 5] + "    *" + GameBoard[2, 6] + "   *" + GameBoard[2, 7] + "    *" + GameBoard[2, 8] + "    *" + GameBoard[2, 9] + "   *\n";

            resultat = resultat + "  *********************************************************\n";

            resultat = resultat + "D * " + GameBoard[3, 0] + "  *" + GameBoard[3, 1] + "    *" + GameBoard[3, 2] + "    *" + GameBoard[3, 3] + "   *" + GameBoard[3, 4] + "    *" + GameBoard[3, 5] + "    *" + GameBoard[3, 6] + "   *" + GameBoard[3, 7] + "    *" + GameBoard[3, 8] + "    *" + GameBoard[3, 9] + "   *\n";

            resultat = resultat + "  *********************************************************\n";

            resultat = resultat + "E * " + GameBoard[4, 0] + "  *" + GameBoard[4, 1] + "    *" + GameBoard[4, 2] + "    *" + GameBoard[4, 3] + "   *" + GameBoard[4, 4] + "    *" + GameBoard[4, 5] + "    *" + GameBoard[4, 6] + "   *" + GameBoard[4, 7] + "    *" + GameBoard[4, 8] + "    *" + GameBoard[4, 9] + "   *\n";

            resultat = resultat + "  *********************************************************\n";

            resultat = resultat + "F * " + GameBoard[5, 0] + "  *" + GameBoard[5, 1] + "    *" + GameBoard[5, 2] + "    *" + GameBoard[5, 3] + "   *" + GameBoard[5, 4] + "    *" + GameBoard[5, 5] + "    *" + GameBoard[5, 6] + "   *" + GameBoard[5, 7] + "    *" + GameBoard[5, 8] + "    *" + GameBoard[5, 9] + "   *\n";

            resultat = resultat + "  *********************************************************\n";

            resultat = resultat + "G * " + GameBoard[6, 0] + "  *" + GameBoard[6, 1] + "    *" + GameBoard[6, 2] + "    *" + GameBoard[6, 3] + "   *" + GameBoard[6, 4] + "    *" + GameBoard[6, 5] + "    *" + GameBoard[6, 6] + "   *" + GameBoard[6, 7] + "    *" + GameBoard[6, 8] + "    *" + GameBoard[6, 9] + "   *\n";

            resultat = resultat + "  *********************************************************\n";

            resultat = resultat + "H * " + GameBoard[7, 0] + "  *" + GameBoard[7, 1] + "    *" + GameBoard[7, 2] + "    *" + GameBoard[7, 3] + "   *" + GameBoard[7, 4] + "    *" + GameBoard[7, 5] + "    *" + GameBoard[7, 6] + "   *" + GameBoard[7, 7] + "    *" + GameBoard[7, 8] + "    *" + GameBoard[7, 9] + "   *\n";

            resultat = resultat + "  *********************************************************\n";

            resultat = resultat + "I * " + GameBoard[8, 0] + "  *" + GameBoard[8, 1] + "    *" + GameBoard[8, 2] + "    *" + GameBoard[8, 3] + "   *" + GameBoard[8, 4] + "    *" + GameBoard[8, 5] + "    *" + GameBoard[8, 6] + "   *" + GameBoard[8, 7] + "    *" + GameBoard[8, 8] + "    *" + GameBoard[8, 9] + "   *\n";

            resultat = resultat + "  *********************************************************\n";

            resultat = resultat + "J * " + GameBoard[9, 0] + "  *" + GameBoard[9, 1] + "    *" + GameBoard[9, 2] + "    *" + GameBoard[9, 3] + "   *" + GameBoard[9, 4] + "    *" + GameBoard[9, 5] + "    *" + GameBoard[9, 6] + "   *" + GameBoard[9, 7] + "    *" + GameBoard[9, 8] + "    *" + GameBoard[9, 9] + "   *\n";

            resultat = resultat + "     1     2     3    4    5     6     7    8     9     10 \n";

            return resultat;
        }
        public string GetRadarView()
        {
            string resultat = "";
            resultat = resultat + "Y\n";
            resultat = resultat + "  *********************************************************\n";

            resultat = resultat + "A * " + radar[0, 0] + "  *" + radar[0, 1] + "    *" + radar[0, 2] + "    *" + radar[0, 3] + "   *" + radar[0, 4] + "    *" + radar[0, 5] + "    *" + radar[0, 6] + "   *" + radar[0, 7] + "    *" + radar[0, 8] + "    *" + radar[0, 9] + "   *\n";

            resultat = resultat + "  *********************************************************\n";

            resultat = resultat + "B * " + radar[1, 0] + "  *" + radar[1, 1] + "    *" + radar[1, 2] + "    *" + radar[1, 3] + "   *" + radar[1, 4] + "    *" + radar[1, 5] + "    *" + radar[1, 6] + "   *" + radar[1, 7] + "    *" + radar[1, 8] + "    *" + radar[1, 9] + "   *\n";

            resultat = resultat + "  *********************************************************\n";

            resultat = resultat + "C * " + radar[2, 0] + "  *" + radar[2, 1] + "    *" + radar[2, 2] + "    *" + radar[2, 3] + "   *" + radar[2, 4] + "    *" + radar[2, 5] + "    *" + radar[2, 6] + "   *" + radar[2, 7] + "    *" + radar[2, 8] + "    *" + radar[2, 9] + "   *\n";

            resultat = resultat + "  *********************************************************\n";

            resultat = resultat + "D * " + radar[3, 0] + "  *" + radar[3, 1] + "    *" + radar[3, 2] + "    *" + radar[3, 3] + "   *" + radar[3, 4] + "    *" + radar[3, 5] + "    *" + radar[3, 6] + "   *" + radar[3, 7] + "    *" + radar[3, 8] + "    *" + radar[3, 9] + "   *\n";

            resultat = resultat + "  *********************************************************\n";

            resultat = resultat + "E * " + radar[4, 0] + "  *" + radar[4, 1] + "    *" + radar[4, 2] + "    *" + radar[4, 3] + "   *" + radar[4, 4] + "    *" + radar[4, 5] + "    *" + radar[4, 6] + "   *" + radar[4, 7] + "    *" + radar[4, 8] + "    *" + radar[4, 9] + "   *\n";

            resultat = resultat + "  *********************************************************\n";

            resultat = resultat + "F * " + radar[5, 0] + "  *" + radar[5, 1] + "    *" + radar[5, 2] + "    *" + radar[5, 3] + "   *" + radar[5, 4] + "    *" + radar[5, 5] + "    *" + radar[5, 6] + "   *" + radar[5, 7] + "    *" + radar[5, 8] + "    *" + radar[5, 9] + "   *\n";

            resultat = resultat + "  *********************************************************\n";

            resultat = resultat + "G * " + radar[6, 0] + "  *" + radar[6, 1] + "    *" + radar[6, 2] + "    *" + radar[6, 3] + "   *" + radar[6, 4] + "    *" + radar[6, 5] + "    *" + radar[6, 6] + "   *" + radar[6, 7] + "    *" + radar[6, 8] + "    *" + radar[6, 9] + "   *\n";

            resultat = resultat + "  *********************************************************\n";

            resultat = resultat + "H * " + radar[7, 0] + "  *" + radar[7, 1] + "    *" + radar[7, 2] + "    *" + radar[7, 3] + "   *" + radar[7, 4] + "    *" + radar[7, 5] + "    *" + radar[7, 6] + "   *" + radar[7, 7] + "    *" + radar[7, 8] + "    *" + radar[7, 9] + "   *\n";

            resultat = resultat + "  *********************************************************\n";

            resultat = resultat + "I * " + radar[8, 0] + "  *" + radar[8, 1] + "    *" + radar[8, 2] + "   *" + radar[8, 3] + "    *" + radar[8, 4] + "    *" + radar[8, 5] + "    *" + radar[8, 6] + "   *" + radar[8, 7] + "    *" + radar[8, 8] + "    *" + radar[8, 9] + "   *\n";

            resultat = resultat + "  *********************************************************\n";

            resultat = resultat + "J * " + radar[9, 0] + "  *" + radar[9, 1] + "    *" + radar[9, 2] + "    *" + radar[9, 3] + "   *" + radar[9, 4] + "    *" + radar[9, 5] + "    *" + radar[9, 6] + "   *" + radar[9, 7] + "    *" + radar[9, 8] + "    *" + radar[9, 9] + "   *\n";

            resultat = resultat + "     1     2     3    4    5     6     7    8     9     10 \n";

            return resultat;
        }

        private int[] select(char[,] Gameboard, Func<string> getView)
        {
            char memory = Gameboard[5, 5];
            int coordX = 5;
            int coordY = 5;

            while (true)
            {
                memory = Gameboard[coordX, coordY];
                Gameboard[coordX, coordY] = 'X';
                Console.Clear();
                Console.WriteLine(getView());
                Console.WriteLine("use arrow keys to move and enter to select");
                
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.UpArrow:
                        Gameboard[coordX, coordY] = memory;
                        if (coordX >= 1 && coordX <= 8) //catches attempts to escape the board
                        {
                            coordX -= 1;
	                    }
                        break;
                    case ConsoleKey.DownArrow:
                        Gameboard[coordX, coordY] = memory;
                        if (coordX >=1 && coordX <=8) //catches attempts to escape the board
                        {
                            coordX += 1;
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                        Gameboard[coordX, coordY] = memory;
                        if (coordY >= 1 && coordY <=8)//catches attempts to escape the board
	                    {
                            coordY -= 1;
	                    }
                        break;
                    case ConsoleKey.RightArrow:
                        Gameboard[coordX, coordY] = memory;
                        if (coordY >=1 && coordY <= 8) //catches attempts to escape the board
	                    {
                            coordY += 1;
	                    }
                        break;
                    case ConsoleKey.Enter:
                        Gameboard[coordX, coordY] = memory;
                        Console.Clear();
                        Console.WriteLine(getView());
                        int[] coords = new int[2];
                        coords[0] = coordX;
                        coords[1] = coordY;
                        return coords;
                    default:
                        break;
                }
            } 
        }

        public bool Shoot()
        {
            int[] selection = select(radar, GetRadarView);
            int selectX = selection[0];
            int selectY = selection[1];
                if (GameBoard[selectX,selectY] == 'S')
            {
                radar[selectX, selectY] = 'H';
                GameBoard[selectX, selectY] = 'H';
                return true;
            }
                else
            {
                radar[selectX, selectY] = 'M';
                return false;
            }
        }

        public bool ChecksIfShipIsInRow()
        {
            return true;
        }

        public bool Place(int shipLength)
        {
            int[] root = select(GameBoard,GetGameBoardView);
            int rootX = root[0];
            int rootY = root[1];
            while (true)
            {
                GetGameBoardView();
                Console.WriteLine("use arrowkeys to select ship direction");
                bool breaking = false;
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.UpArrow:
                        for (int i = 0; i < shipLength; i++)
                        {
                            if (GameBoard[rootX - i , rootY] != ' ')
                            {
                                breaking = true;
                                break;
                            }
                        }
                        if (breaking == true) { continue; }
                        for (int i = 0; i < shipLength; i++)
                        {
                            GameBoard[rootX - i, rootY] = 'S';
                        }
                        return true;

                    case ConsoleKey.DownArrow:
                        for (int i = 0; i < shipLength; i++)
                        {
                            if (GameBoard[rootX + i, rootY] != ' ')
                            {
                                breaking = false;
                                break;
                            }
                        }
                        if (breaking == true) { continue; }
                            for (int i = 0; i < shipLength; i++)
                            {
                                GameBoard[rootX + i, rootY] = 'S';
                            }
                        return true;

                    case ConsoleKey.LeftArrow:
                        for (int i = 0; i < shipLength; i++)
                        {
                            if (GameBoard[rootX - 1, rootY] != ' ')
                            {
                                breaking = false;
                                break;
                            }
                        }
                        if (breaking == true) { continue; }
                        for (int i = 0; i < shipLength; i++)
                            {
                                GameBoard[rootX, rootY - i] = 'S';
                            }
                        return true;
                    case ConsoleKey.RightArrow:
                        for (int i = 0; i < shipLength; i++)
                        {
                            if (GameBoard[rootX + 1, rootY] != ' ')
                            {
                                break;
                            }
                        }
                        if (breaking == true) { continue; }
                        for (int i = 0; i < shipLength; i++)
                        {
                            GameBoard[rootX, rootY + i] = 'S';
                        }
                        return true;
                    default:
                        continue;
                }
            }
        }
    }
}
