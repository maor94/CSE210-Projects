using System;
using System.Collections.Generic;

namespace SandboxProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GreetingDisplay();

            List<string> board = GetNewBoard();

            BoardDisplay(board);

            string currentPlayer = "x";

            int squareChoice = GetUserChoice(currentPlayer);
            MakeMove(board, currentPlayer, squareChoice);
            BoardDisplay(board);
            Console.WriteLine(" "); //Empty Line
            
            currentPlayer = "o";

            squareChoice = GetUserChoice(currentPlayer);
            MakeMove(board, currentPlayer, squareChoice);
            BoardDisplay(board);
            Console.WriteLine(" "); //Empty Line

            currentPlayer = "x";

            squareChoice = GetUserChoice(currentPlayer);
            MakeMove(board, currentPlayer, squareChoice);
            BoardDisplay(board);
            Console.WriteLine(" "); //Empty Line
            
            currentPlayer = "o";

            squareChoice = GetUserChoice(currentPlayer);
            MakeMove(board, currentPlayer, squareChoice);
            BoardDisplay(board);
            Console.WriteLine(" "); //Empty Line

            currentPlayer = "x";

            squareChoice = GetUserChoice(currentPlayer);
            MakeMove(board, currentPlayer, squareChoice);
            BoardDisplay(board);
            Console.WriteLine(" "); //Empty Line
            
            currentPlayer = "o";

            squareChoice = GetUserChoice(currentPlayer);
            MakeMove(board, currentPlayer, squareChoice);
            BoardDisplay(board);
            Console.WriteLine(" "); //Empty Line

            currentPlayer = "x";

            squareChoice = GetUserChoice(currentPlayer);
            MakeMove(board, currentPlayer, squareChoice);
            BoardDisplay(board);
            Console.WriteLine(" "); //Empty Line
            
            currentPlayer = "o";

            squareChoice = GetUserChoice(currentPlayer);
            MakeMove(board, currentPlayer, squareChoice);
            BoardDisplay(board);
            Console.WriteLine(" "); //Empty Line

           currentPlayer = "x";

            squareChoice = GetUserChoice(currentPlayer);
            MakeMove(board, currentPlayer, squareChoice);
            BoardDisplay(board);
            Console.WriteLine(" "); //Empty Line

            Console.WriteLine("Thanks for Playing");

        }
///////////////////
        static int GetUserChoice(string currentPlayer)
        {
            Console.Write($"{currentPlayer}'s turn to choose a square (1-9): ");
            int squareChoice = int.Parse(Console.ReadLine()); //Changing the user's input from string to integer
            return squareChoice;
        }

///////////////////
        static void MakeMove(List<string>board, string currentPlayer, int squareChoice)
        {
            int boardIndex = squareChoice - 1;
            board[boardIndex] = currentPlayer;
        }

///////////////////
        static List<string> GetNewBoard()
        {   
            List<string> board = new List<string>();
            for(int i = 1; i<10; i++)
            {
                board.Add(i.ToString());
            }

            return board;
        }

//////////////////
        static void BoardDisplay(List<string> board)
        {
            Console.WriteLine($"{board[0]}|{board[1]}|{board[2]}");
            Console.WriteLine("-+-+-");
            Console.WriteLine($"{board[3]}|{board[4]}|{board[5]}");
            Console.WriteLine("-+-+-");
            Console.WriteLine($"{board[6]}|{board[7]}|{board[8]}");
        }

//////////////////
        static void GreetingDisplay()
        {
            Console.WriteLine("Welcome to the Tic Tac Toe Program");
        }
    }
}
