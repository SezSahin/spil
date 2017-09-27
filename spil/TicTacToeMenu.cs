using System;

namespace spil
{
    public class TicTacToeMenu
    {
        TicTacToe ticTacToe { get; set; }
        bool running = true;
        public void Show()
        {
            string choice = "";
            do
            {
                ShowMenu();
                choice = GetUserChoise();
                switch (choice)
                {
                    case "1": DoActionFor1(); break;
                    case "2": DoActionFor2(); break;
                    case "3": DoActionFor3(); break;
                    case "0": running = false; break;
                    default: ShowMenuSelectionErroe(); break;
                }
            } while (running);
        }

        public void ShowMenu()
        {
            Console.Clear();
            if (ticTacToe != null)
            {
                Console.WriteLine(ticTacToe.GetGameBoardView());
                if (TicTacToe.Validate(ticTacToe.GameBoard) != ' ')
                {
                    Console.WriteLine("player " + TicTacToe.Validate(ticTacToe.GameBoard));
                    Console.WriteLine("A Winner is You!");
                    running = false;
                }
            }
            Console.WriteLine("tic tac toe");
            Console.WriteLine();
            Console.WriteLine("1. Opret et nyt spil");
            Console.WriteLine("2. Set en brik");
            Console.WriteLine("3. Flyt en brik");
            Console.WriteLine();
            Console.WriteLine("0. exit");
        }


        private string GetUserChoise()
        {
            Console.WriteLine();
            Console.Write("Indtast dit valg: ");
            return Console.ReadLine();
        }

        private void ShowMenuSelectionErroe()
        {
            Console.WriteLine("Ugyldigt valg.");
            Console.ReadLine();
        }

        private void DoActionFor1()
        {
            ticTacToe = new TicTacToe();
        }
        private void DoActionFor2()
        {
            Console.WriteLine("indtast koordinater");
            ticTacToe.Place(Int32.Parse(Console.ReadLine()) - 1, Int32.Parse(Console.ReadLine()) - 1);
        }
        private void DoActionFor3()
        {
            Console.WriteLine("skriv koden til at få spillerens input til at flytte en brik");
            Console.ReadLine();
        }
    }
}