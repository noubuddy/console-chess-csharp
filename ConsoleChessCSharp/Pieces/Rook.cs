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

            // up
            for (int i = posY - 1; i >= 0; i--)
            {
                if (LegalMoves(posX, (byte)i, legalMoves)) { break; }
                legalMoves.Add((posX, (byte)i));
            }

            // down
            for (int i = posY + 1; i <= 7; i++)
            {
                if (LegalMoves(posX, (byte)i, legalMoves)) { break; }
                legalMoves.Add((posX, (byte)i));
            }

            // left
            for (int i = posX - 1; i >= 0; i--)
            {
                if (LegalMoves((byte)i, posY, legalMoves)) { break; }
                legalMoves.Add(((byte)i, posY));
            }

            // right
            for (int i = posX + 1; i <= 7; i++)
            {
                if (LegalMoves((byte)i, posY, legalMoves)) { break; }
                legalMoves.Add(((byte)i, posY));
            }

            return legalMoves;
        }
    }
}