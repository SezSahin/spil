using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spil
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            Console.WriteLine("press 1 for TicTacToe, or 2 for BattleShips");
            Console.WriteLine();
            switch (Console.ReadLine())
            {
                case "1":
                    myProgram.RunTicTacToe();
                    break;
                case "2":
                    myProgram.RunBattleShips();
                    break;
                default:
                    throw new Exception();
            }

        }
            
        

        private void RunTicTacToe()
        {
            TicTacToeMenu ticTacToeMenu = new TicTacToeMenu();
            ticTacToeMenu.Show();
        }
        private void RunBattleShips()
        {
            BattleShipsHandler handler = new BattleShipsHandler();
            handler.start();
        }
    }

}
