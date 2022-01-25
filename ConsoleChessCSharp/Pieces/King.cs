namespace ConsoleChessCSharp.Pieces
{
    public class King : Pieces
    {
        public King(char piece, string color, string position) : base(piece, color, position)
        {
        }

        public override List<(byte, byte)> LegalMoves(string position)
        {
            List<(byte, byte)> legalMoves = new();

            Chess.GetPosition(position, out byte posX, out byte posY);

            legalMoves.Add(((byte)(posX - 1), (byte)(posY - 1)));
            legalMoves.Add(((byte)(posX), (byte)(posY - 1)));
            legalMoves.Add(((byte)(posX + 1), (byte)(posY - 1)));
            legalMoves.Add(((byte)(posX + 1), (byte)(posY)));
            legalMoves.Add(((byte)(posX + 1), (byte)(posY + 1)));
            legalMoves.Add(((byte)(posX), (byte)(posY + 1)));
            legalMoves.Add(((byte)(posX - 1), (byte)(posY + 1)));
            legalMoves.Add(((byte)(posX - 1), (byte)(posY)));

            return legalMoves;
        }
    }
}