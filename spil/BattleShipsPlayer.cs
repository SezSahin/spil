using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spil
{
    class BattleShipsPlayer : IBattleShips
    {
        private char[,] Gameboard;
        private char[,] Radar;

        BattleShipsPlayer()
            // H is Hit
            // M is Miss
            // S is Ship
        {
            Gameboard = new char[10, 10]
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
            Radar = new char[10, 10]
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
            throw new NotImplementedException();
        }

        public string GetGameBoardView()
        {
            throw new NotImplementedException();
        }

        public string GetRadarWiew()
        {
            throw new NotImplementedException();
        }

        private int[] select()
        {
            char memory = Gameboard[5, 5];
            int coordX = 5;
            int coordY = 5;

            while (true)
            {
                memory = Gameboard[coordX, coordY];
                Gameboard[coordX, coordY] = 'X';
                GetGameBoardView();
                Console.WriteLine("use arrow keys to move and enter to select");
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.UpArrow:
                        Gameboard[coordX, coordY] = memory;
                        coordY -= 1;
                        break;
                    case ConsoleKey.DownArrow:
                        Gameboard[coordX, coordY] = memory;
                        coordY += 1;
                        break;
                    case ConsoleKey.LeftArrow:
                        Gameboard[coordX, coordY] = memory;
                        coordX -= 1;
                        break;
                    case ConsoleKey.RightArrow:
                        Gameboard[coordX, coordY] = memory;
                        coordX += 1;
                        break;
                    case ConsoleKey.Enter:
                        Gameboard[coordX, coordY] = memory;
                        int[] coords = new int[] { coordX, coordY };
                        return coords;
                    default:
                        break;
                }
            } 
        }

        public bool Shoot(int x, int y)
        {
            throw new NotImplementedException();
        }

        public bool Place(int shipLength)
        {
            int[] root = select();
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
                            if (Gameboard[rootX, rootY - i] != ' ')
                            {
                                breaking = true;
                                break;
                            }
                        }
                        if (breaking == true) { continue; }
                        for (int i = 0; i >= shipLength; i++)
                        {
                            Gameboard[rootX, rootY - i] = 'S';
                        }
                        return true;

                    case ConsoleKey.DownArrow:
                        for (int i = 0; i >= shipLength; i++)
                        {
                            if (Gameboard[rootX, rootY + i] != ' ')
                            {
                                breaking = false;
                                break;
                            }
                        }
                        if (breaking == true) { continue; }
                            for (int i = 0; i >= shipLength; i++)
                            {
                                Gameboard[rootX, rootY + i] = 'S';
                            }
                        return true;

                    case ConsoleKey.LeftArrow:
                        for (int i = 0; i >= shipLength; i++)
                        {
                            if (Gameboard[rootX - 1, rootY] != ' ')
                            {
                                breaking = false;
                                break;
                            }
                        }
                        if (breaking == true) { continue; }
                        for (int i = 0; i >= shipLength; i++)
                            {
                                Gameboard[rootX, rootY - i] = 'S';
                            }
                        return true;
                    case ConsoleKey.RightArrow:
                        for (int i = 0; i >= shipLength; i++)
                        {
                            if (Gameboard[rootX + 1, rootY] != ' ')
                            {
                                break;
                            }
                        }
                        if (breaking == true) { continue; }
                        for (int i = 0; i >= shipLength; i++)
                        {
                                Gameboard[rootX, rootY + i] = 'S';
                        }
                        return true;
                    default:
                        continue;
                }
            }
        }
    }
}
