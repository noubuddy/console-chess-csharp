namespace ConsoleChessCSharp
{
#nullable disable
    public class Draw
    {
        private const string top = " --------------------------------";
        private readonly char[] letters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };
        private readonly byte size = 8;
        public static char[,] chessboard;
        private bool[,] isWhite;
        public static readonly char emptyCell = ' ';

        // Create (draw) a chessboard
        public void Init()
        {
            Console.Clear();
            chessboard = new char[size, size];
            isWhite = new bool[size, size];

            AssignEmptyCell();
            AssignNotEmptyCell();
            Update();
        }


        // Assign an empty field for all cells 
        private void AssignEmptyCell()
        {
            for (int i = 0; i < chessboard.GetLength(0); i++)
                for (int j = 0; j < chessboard.GetLength(1); j++)
                    chessboard[i, j] = emptyCell;
        }


        // Assign a character of figure for not empty cells
        private void AssignNotEmptyCell()
        {
            foreach (var piece in Chess.PieceList)
            {
                Chess.GetPosition(piece.Position, out byte posX, out byte posY);
                chessboard[posX, posY] = piece.Piece != emptyCell ? piece.Piece : emptyCell;
                isWhite[posX, posY] = piece.Color == Pieces.Pieces.white;
            }

        }


        // Draw a chessboard in console
        private void Update()
        {
            for (int y = 0; y < size; y++)
            {
                Console.WriteLine("  " + top);
                Console.Write(" " + (size - y));

                for (int x = 0; x < size; x++)
                {
                    Console.Write("|");

                    MarkLegalMoves(x, y);
                    Console.ForegroundColor = !isWhite[x, y] ? ConsoleColor.DarkGray : ConsoleColor.White;
                    Console.Write(chessboard[x, y] != emptyCell ? " " + chessboard[x, y] + " " : "   ");
                    //Console.Write(chessboard[x, y] != emptyCell ? x.ToString() + chessboard[x, y] + y.ToString() : x.ToString() + " " + y.ToString());
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;

                }
                Console.WriteLine("|");
            }

            Console.WriteLine("  " + top);
            Console.Write("   ");

            for (int i = 0; i < size; i++)
                Console.Write(" " + letters[i] + "  ");
        }


        // Mark (highlight) all legal moves
        private void MarkLegalMoves(int x, int y)
        {
            if (!string.IsNullOrEmpty(Program.from))
            {
                var piece = Chess.PieceList.Where(t => t.Position.Contains(Program.from)).First();

                List<(byte, byte)> legalMoves = piece.LegalMoves(Program.from);

                foreach (var lm in legalMoves)
                    if (x == lm.Item1 && y == lm.Item2)
                        Console.BackgroundColor = ConsoleColor.Green;
            }
        }

    }
}
