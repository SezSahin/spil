using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spil
{
    public struct Ships
    {
        public int Hangarskib;
        public int Slagskib;
        public int Destroyer;
        public int Ubåd;
        public int Patruljebåd;
    }

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

        public object CheckLoss()
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

            resultat = resultat + "C * " + GameBoard[2, 0] + "   *" + GameBoard[2, 1] + "   *" + GameBoard[2, 2] + "    *" + GameBoard[2, 3] + "   *" + GameBoard[2, 4] + "    *" + GameBoard[2, 5] + "    *" + GameBoard[2, 6] + "   *" + GameBoard[2, 7] + "    *" + GameBoard[2, 8] + "    *" + GameBoard[2, 9] + "   *\n";

            resultat = resultat + "  *********************************************************\n";

            resultat = resultat + "D * " + GameBoard[3, 0] + "   *" + GameBoard[3, 1] + "   *" + GameBoard[3, 2] + "    *" + GameBoard[3, 3] + "   *" + GameBoard[3, 4] + "    *" + GameBoard[3, 5] + "    *" + GameBoard[3, 6] + "   *" + GameBoard[3, 7] + "    *" + GameBoard[3, 8] + "    *" + GameBoard[3, 9] + "   *\n";

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

            resultat = resultat + "A * " + GameBoard[0, 0] + "  *" + GameBoard[0, 1] + "    *" + GameBoard[0, 2] + "    *" + GameBoard[0, 3] + "   *" + GameBoard[0, 4] + "    *" + GameBoard[0, 5] + "    *" + GameBoard[0, 6] + "   *" + GameBoard[0, 7] + "    *" + GameBoard[0, 8] + "    *" + GameBoard[0, 9] + "   *\n";

            resultat = resultat + "  *********************************************************\n";

            resultat = resultat + "B * " + GameBoard[1, 0] + "  *" + GameBoard[1, 1] + "    *" + GameBoard[1, 2] + "    *" + GameBoard[1, 3] + "   *" + GameBoard[1, 4] + "    *" + GameBoard[1, 5] + "    *" + GameBoard[1, 6] + "   *" + GameBoard[1, 7] + "    *" + GameBoard[1, 8] + "    *" + GameBoard[1, 9] + "   *\n";

            resultat = resultat + "  *********************************************************\n";

            resultat = resultat + "C * " + GameBoard[2, 0] + "   *" + GameBoard[2, 1] + "   *" + GameBoard[2, 2] + "    *" + GameBoard[2, 3] + "   *" + GameBoard[2, 4] + "    *" + GameBoard[2, 5] + "    *" + GameBoard[2, 6] + "   *" + GameBoard[2, 7] + "    *" + GameBoard[2, 8] + "    *" + GameBoard[2, 9] + "   *\n";

            resultat = resultat + "  *********************************************************\n";

            resultat = resultat + "D * " + GameBoard[3, 0] + "   *" + GameBoard[3, 1] + "   *" + GameBoard[3, 2] + "    *" + GameBoard[3, 3] + "   *" + GameBoard[3, 4] + "    *" + GameBoard[3, 5] + "    *" + GameBoard[3, 6] + "   *" + GameBoard[3, 7] + "    *" + GameBoard[3, 8] + "    *" + GameBoard[3, 9] + "   *\n";

            resultat = resultat + "  *********************************************************\n";

            resultat = resultat + "E * " + GameBoard[4, 0] + "  *" + GameBoard[4, 1] + "    *" + GameBoard[4, 2] + "    *" + GameBoard[4, 3] + "   *" + GameBoard[4, 4] + "    *" + GameBoard[4, 5] + "    *" + GameBoard[4, 6] + "   *" + GameBoard[4, 7] + "    *" + GameBoard[4, 8] + "    *" + GameBoard[4, 9] + "   *\n";

            resultat = resultat + "  *********************************************************\n";

            resultat = resultat + "F * " + GameBoard[5, 0] + "  *" + GameBoard[5, 1] + "    *" + GameBoard[5, 2] + "    *" + GameBoard[5, 3] + "   *" + GameBoard[5, 4] + "    *" + GameBoard[5, 5] + "    *" + GameBoard[5, 6] + "   *" + GameBoard[5, 7] + "    *" + GameBoard[5, 8] + "    *" + GameBoard[5, 9] + "   *\n";

            resultat = resultat + "  *********************************************************\n";

            resultat = resultat + "G * " + GameBoard[6, 0] + "  *" + GameBoard[6, 1] + "    *" + GameBoard[6, 2] + "    *" + GameBoard[6, 3] + "   *" + GameBoard[6, 4] + "    *" + GameBoard[6, 5] + "    *" + GameBoard[6, 6] + "   *" + GameBoard[6, 7] + "    *" + GameBoard[6, 8] + "    *" + GameBoard[6, 9] + "   *\n";

            resultat = resultat + "  *********************************************************\n";

            resultat = resultat + "H * " + GameBoard[7, 0] + "  *" + GameBoard[7, 1] + "    *" + GameBoard[7, 2] + "    *" + GameBoard[7, 3] + "   *" + GameBoard[7, 4] + "    *" + GameBoard[7, 5] + "    *" + GameBoard[7, 6] + "   *" + GameBoard[7, 7] + "    *" + GameBoard[7, 8] + "    *" + GameBoard[7, 9] + "   *\n";

            resultat = resultat + "  *********************************************************\n";

            resultat = resultat + "I * " + GameBoard[8, 0] + "  *" + GameBoard[8, 1] + "    *" + GameBoard[8, 2] + "   *" + GameBoard[8, 3] + "    *" + GameBoard[8, 4] + "    *" + GameBoard[8, 5] + "    *" + GameBoard[8, 6] + "   *" + GameBoard[8, 7] + "    *" + GameBoard[8, 8] + "    *" + GameBoard[8, 9] + "   *\n";

            resultat = resultat + "  *********************************************************\n";

            resultat = resultat + "J * " + GameBoard[9, 0] + "  *" + GameBoard[9, 1] + "    *" + GameBoard[9, 2] + "    *" + GameBoard[9, 3] + "   *" + GameBoard[9, 4] + "    *" + GameBoard[9, 5] + "    *" + GameBoard[9, 6] + "   *" + GameBoard[9, 7] + "    *" + GameBoard[9, 8] + "    *" + GameBoard[9, 9] + "   *\n";

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
                Gameboard[coordX, coordY] = 'M';
                Console.Clear();
                Console.WriteLine(getView());
                Console.WriteLine("use arrow keys to move and enter to select");
                
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.UpArrow:
                        Gameboard[coordX, coordY] = memory;
                        if (coordX >= 1 && coordX <= 9) //catches attempts to escape the board
                        {
                            coordX -= 1;
	                    }
                        break;
                    case ConsoleKey.DownArrow:
                        Gameboard[coordX, coordY] = memory;
                        if (coordX >=0 && coordX <=8) //catches attempts to escape the board
                        {
                            coordX += 1;
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                        Gameboard[coordX, coordY] = memory;
                        if (coordY >= 1 && coordY <=9)//catches attempts to escape the board
	                    {
                            coordY -= 1;
	                    }
                        break;
                    case ConsoleKey.RightArrow:
                        Gameboard[coordX, coordY] = memory;
                        if (coordY >=0 && coordY <= 8) //catches attempts to escape the board
	                    {
                            coordY += 1;
	                    }
                        break;
                    /*case ConsoleKey.H: //case for "Hangarskib" placering
                        Gameboard[coordX, coordY] = memory;
                        int[] coords = new int[] { coordX, coordY };
                        return coords;
                    case ConsoleKey.S: //case for "Slagskibs" placering
                        Gameboard[coordX, coordY] = memory;
                        int[] coords = new int[] { coordX, coordY };
                        return coords;
                    case ConsoleKey.D: //case for "Destroyer" placering
                        Gameboard[coordX, coordY] = memory;
                        int[] coords = new int[] { coordX, coordY };
                        return coords;
                    case ConsoleKey.U: //case for "ubåds" placering
                        Gameboard[coordX, coordY] = memory;
                        int[] coords = new int[] { coordX, coordY };
                        return coords;
                    case ConsoleKey.P: //case for "pautruljebåds" placering
                        Gameboard[coordX, coordY] = memory;
                        int[] coords = new int[] { coordX, coordY };
                        return coords;*/ //Virker pt. ikke korrekt.
                    
                    
                    default:
                        break;
                }
            } 
        }

        public bool Shoot()
        {
            int[] selection = select(radar,GetRadarView);
            return true;
            

        }

        public bool ChecksIfShipIsInRow()
        {
            return true;
        }

        public bool Place(int shipLength)
        {
            Ships ships = new Ships();
            ships.Hangarskib = 5;
            ships.Slagskib = 4;
            ships.Destroyer = 3;
            ships.Ubåd = 3;
            ships.Patruljebåd = 2;

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
                        for (int i = 0; i >= shipLength; i++)
                        {
                            if (GameBoard[rootX, rootY - i] != ' ')
                            {
                                breaking = true;
                                break;
                            }
                        }
                        if (breaking == true) { continue; }
                        for (int i = 0; i >= shipLength; i++)
                        {
                            GameBoard[rootX, rootY - i] = 'S';
                        }
                        return true;

                    case ConsoleKey.DownArrow:
                        for (int i = 0; i >= shipLength; i++)
                        {
                            if (GameBoard[rootX, rootY + i] != ' ')
                            {
                                breaking = false;
                                break;
                            }
                        }
                        if (breaking == true) { continue; }
                            for (int i = 0; i >= shipLength; i++)
                            {
                                GameBoard[rootX, rootY + i] = 'S';
                            }
                        return true;

                    case ConsoleKey.LeftArrow:
                        for (int i = 0; i >= shipLength; i++)
                        {
                            if (GameBoard[rootX - 1, rootY] != ' ')
                            {
                                breaking = false;
                                break;
                            }
                        }
                        if (breaking == true) { continue; }
                        for (int i = 0; i >= shipLength; i++)
                            {
                                GameBoard[rootX, rootY - i] = 'S';
                            }
                        return true;
                    case ConsoleKey.RightArrow:
                        for (int i = 0; i >= shipLength; i++)
                        {
                            if (GameBoard[rootX + 1, rootY] != ' ')
                            {
                                break;
                            }
                        }
                        if (breaking == true) { continue; }
                        for (int i = 0; i >= shipLength; i++)
                        {
                            GameBoard[rootX, rootY + i] = 'S';
                        }
                        return true;
                    case ConsoleKey.Enter:
                        if (GameBoard[rootX, rootY] == 'S')
                        {
                            Console.WriteLine("Det er ikke muligt at sætte en brik her");
                            Console.WriteLine("Prøv igen");
                            Console.ReadLine();
                            Console.Clear();
                            return false;
                        }
                        if (currentPlayer)
                        {
                            GameBoard[rootX, rootY] = 'S';
                        }
                        currentPlayer = !currentPlayer;
                        return true;
                    default:
                        continue;
                }
            }
        }
    }
}
