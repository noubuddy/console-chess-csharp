using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleChessCSharp.Pieces;

namespace ConsoleChessCSharp
{
    public class Draw
    {
        const string top = " --------------------------------";
        //List<(byte, byte)> legalMoves = pieces.legalMoves(from);

        //              foreach (var moves in legalMoves)
        //              {
        //                  Console.WriteLine(moves.Item1 + " - " + moves.Item2);
        //              }

        // Create (draw) a Chess.chessboard
        public void Init()
        {
            Console.Clear();
            Chess.isInit = true;
            Chess.chessboard = new char[Chess.size, Chess.size];
            Chess.isWhite = new bool[Chess.size, Chess.size];

            AssignEmptyCell();
            AssignNotEmptyCell();
            Update();
        }

        private void AssignEmptyCell()
        {
            // Assign an empty field for all cells
            for (int i = 0; i < Chess.chessboard.GetLength(0); i++)
                for (int j = 0; j < Chess.chessboard.GetLength(1); j++)
                {
                    Chess.chessboard[i, j] = Chess.emptyCell;
                }
        }

        private void AssignNotEmptyCell()
        {
            // Assign a character of figure for not empty cells
            if (!Chess.isEmptyBoard)
            {
                foreach (KeyValuePair<string, Tuple<char, string>> cell in Chess.pieces)
                {
                    Chess.GetPosition(cell.Key, out byte posX, out byte posY);
                    Chess.chessboard[posX, posY] = cell.Value.Item1 != Chess.emptyCell ? cell.Value.Item1 : Chess.emptyCell;
                    Chess.isWhite[posX, posY] = cell.Value.Item2 == "white";
                }
            }
        }

        private void Update()
        {
            // Draw a Chess.chessboard in console
            for (int y = 0; y < Chess.size; y++)
            {
                Console.WriteLine("  " + top);
                Console.Write(" " + (Chess.size - y));

                for (int x = 0; x < Chess.size; x++)
                {
                    Console.Write("|");

                    MarkLegalMoves(x, y);
                    Console.ForegroundColor = !Chess.isWhite[x, y] ? ConsoleColor.DarkGray : ConsoleColor.White;
                    Console.Write(Chess.chessboard[x, y] != Chess.emptyCell ? " " + Chess.chessboard[x, y] + " " : "   ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;

                }
                Console.WriteLine("|");
            }

            Console.WriteLine("  " + top);
            Console.Write("   ");

            for (int i = 0; i < Chess.size; i++)
                Console.Write(" " + Chess.letters[i] + "  ");
        }

        public void MarkLegalMoves(int x, int y)
        {
            if (!string.IsNullOrEmpty(Program.from))
            {
                Piece pieces = new();
                List<(byte, byte)> legalMoves = pieces.legalMoves(Program.from);

                foreach (var lm in legalMoves)
                {
                    if (x == lm.Item1 && y == lm.Item2)
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                    }
                }
            }
        }


    }
}
