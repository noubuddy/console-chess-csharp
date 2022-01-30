namespace ConsoleChessCSharp.Pieces
{
    public abstract class Pieces
    {
        public char Piece { get; private set; }
        public string Color { get; private set; }
        public string Position { get; set; }
        public static readonly string white = "white";
        public static readonly string black = "black";

        public Pieces(char piece, string color, string position)
        {
            Piece = piece;
            Color = color;
            Position = position;
        }

        public static Pieces AddNewPiece(Pieces piece, string cellFrom)
        {
            return piece.Piece switch
            {
                'p' => new Pawn(piece.Piece, piece.Color, cellFrom),
                'r' => new Rook(piece.Piece, piece.Color, cellFrom),
                'k' => new Knight(piece.Piece, piece.Color, cellFrom),
                'b' => new Bishop(piece.Piece, piece.Color, cellFrom),
                'K' => new King(piece.Piece, piece.Color, cellFrom),
                'q' => new Queen(piece.Piece, piece.Color, cellFrom),
                _ => throw new NotImplementedException(),
            };
        }

        public abstract List<(byte, byte)> LegalMoves(string position);
    }
}
