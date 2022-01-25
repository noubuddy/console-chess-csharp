namespace ConsoleChessCSharp.Pieces
{
    public class Knight : Pieces
    {
        public Knight(char piece, string color, string position) : base(piece, color, position)
        {
        }

        public override List<(byte, byte)> LegalMoves(string position)
        {
            List<(byte, byte)> legalMoves = new();

            Chess.GetPosition(position, out byte posX, out byte posY);

            legalMoves.Add(((byte)(posX - 1), (byte)(posY - 2)));
            legalMoves.Add(((byte)(posX + 1), (byte)(posY - 2)));

            legalMoves.Add(((byte)(posX - 2), (byte)(posY - 1)));
            legalMoves.Add(((byte)(posX - 2), (byte)(posY + 1)));

            legalMoves.Add(((byte)(posX - 1), (byte)(posY + 2)));
            legalMoves.Add(((byte)(posX + 1), (byte)(posY + 2)));

            legalMoves.Add(((byte)(posX + 2), (byte)(posY + 1)));
            legalMoves.Add(((byte)(posX + 2), (byte)(posY - 1)));

            return legalMoves;
        }
    }
}