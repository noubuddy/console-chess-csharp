using ConsoleChessCSharp.Pieces;

namespace ConsoleChessCSharp
{
    public class Chess
    {
        // Convert position to array coordinate values
        public static void GetPosition(string cellPosition, out byte posX, out byte posY)
        {
            char x = char.ToLower(cellPosition[0]);
            char y = cellPosition[1];

            posX = x switch
            {
                'a' => 0,
                'b' => 1,
                'c' => 2,
                'd' => 3,
                'e' => 4,
                'f' => 5,
                'g' => 6,
                'h' => 7,
                _ => throw new Exception("Some text"),
            };
            posY = y switch
            {
                '1' => 7,
                '2' => 6,
                '3' => 5,
                '4' => 4,
                '5' => 3,
                '6' => 2,
                '7' => 1,
                '8' => 0,
                _ => throw new Exception("Some text"),
            };
        }



        // Move a piece to a specific cell
        public static void Move(string from, string to)
        {
            var cell = PieceList.Where(t => t.Position.Contains(from)).First();

            PieceList.Add(Pieces.Pieces.AddNewPiece(cell, to));
            PieceList.Remove(cell);
        }


        // List of all the pieces
        public static readonly List<Pieces.Pieces> PieceList = new()
        {
            // White pieces

            // Pawns
            new Pawn('p', Pieces.Pieces.white, "A2"),
            new Pawn('p', Pieces.Pieces.white, "B2"),
            new Pawn('p', Pieces.Pieces.white, "C2"),
            new Pawn('p', Pieces.Pieces.white, "D2"),
            new Pawn('p', Pieces.Pieces.white, "E2"),
            new Pawn('p', Pieces.Pieces.white, "F2"),
            new Pawn('p', Pieces.Pieces.white, "G2"),
            new Pawn('p', Pieces.Pieces.white, "H2"),

            // Rooks
            new Rook('r', Pieces.Pieces.white, "A1"),
            new Rook('r', Pieces.Pieces.white, "H1"),

            // Knights
            new Knight('k', Pieces.Pieces.white, "B1"),
            new Knight('k', Pieces.Pieces.white, "G1"),

            // Bishops
            new Bishop('b', Pieces.Pieces.white, "C1"),
            new Bishop('b', Pieces.Pieces.white, "F1"),

            // Queen and King
            new Queen('q', Pieces.Pieces.white, "E1"),
            new King('K', Pieces.Pieces.white, "D1"),

            // Black pieces

            // Pawns
            new Pawn('p', Pieces.Pieces.black, "A7"),
            new Pawn('p', Pieces.Pieces.black, "B7"),
            new Pawn('p', Pieces.Pieces.black, "C7"),
            new Pawn('p', Pieces.Pieces.black, "D7"),
            new Pawn('p', Pieces.Pieces.black, "E7"),
            new Pawn('p', Pieces.Pieces.black, "F7"),
            new Pawn('p', Pieces.Pieces.black, "G7"),
            new Pawn('p', Pieces.Pieces.black, "H7"),

            // Rooks
            new Rook('r', Pieces.Pieces.black, "A8"),
            new Rook('r', Pieces.Pieces.black, "H8"),

            // Knights
            new Knight('k', Pieces.Pieces.black, "B8"),
            new Knight('k', Pieces.Pieces.black, "G8"),

            // Bishops
            new Bishop('b', Pieces.Pieces.black, "C8"),
            new Bishop('b', Pieces.Pieces.black, "F8"),

            // Queen and King
            new Queen('q', Pieces.Pieces.black, "E8"),
            new King('K', Pieces.Pieces.black, "D8"),
        };
    }
}
