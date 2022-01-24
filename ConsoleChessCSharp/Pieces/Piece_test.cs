using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleChessCSharp.Pieces
{
    public abstract class Piece_test
    {
        public char Piece { get; private set; }
        public string Color { get; private set; }
        public string Position { get; private set; }

        public static readonly string white = "white";
        public static string black = "black";

        public Piece_test(char piece, string color, string position)
        {
            this.Piece = piece;
            this.Color = color;
            this.Position = position;
        }

        public abstract List<(byte, byte)> legalMoves(string position);
    }
}
