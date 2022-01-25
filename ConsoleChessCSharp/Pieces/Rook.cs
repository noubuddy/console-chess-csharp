namespace ConsoleChessCSharp.Pieces
{
    public class Rook : Pieces
    {
        public Rook(char piece, string color, string position) : base(piece, color, position)
        {
        }

        public override List<(byte, byte)> LegalMoves(string position)
        {
            List<(byte, byte)> legalMoves = new();

            Chess.GetPosition(position, out byte posX, out byte posY);

            for (int i = 0; i < 8; i++)
            {
                legalMoves.Add((posX, (byte)i));
                legalMoves.Add(((byte)i, posY));
                legalMoves.Remove((posX, posY));
            }

            return legalMoves;
        }
    }
}