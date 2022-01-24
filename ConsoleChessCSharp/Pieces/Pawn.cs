namespace ConsoleChessCSharp.Pieces
{
    public class Pawn : Piece_test
    {
        public Pawn(char piece, string color, string position) : base(piece, color, position)
        {
        }

        public override List<(byte, byte)> legalMoves(string position)
        {
            List<(byte, byte)> legalMoves = new();

            Chess.GetPosition(position, out byte posX, out byte posY);

            if (posY == 6)
            {
                legalMoves.Add((posX, (byte)(posY - 1)));
                legalMoves.Add((posX, (byte)(posY - 2)));
            }
            else
            {
                legalMoves.Add((posX, (byte)(posY - 1)));
            }

            return legalMoves;
        }
    }
}