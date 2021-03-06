namespace ConsoleChessCSharp.Pieces
{
    public class Queen : Pieces
    {
        public Queen(char piece, string color, string position) : base(piece, color, position)
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

            // Not done yet!!!

            // up, left
            for (int i = posX, j = posY; i >= 0 || j >= 0; i--)
            {
                legalMoves.Add(((byte)i, (byte)(j--)));
            }

            // up, right
            for (int i = posX, j = posY; i < 8; i++)
            {
                legalMoves.Add(((byte)i, (byte)(j--)));
            }

            // down, left
            for (int i = posX, j = posY; i >= 0; i--)
            {
                legalMoves.Add(((byte)i, (byte)(j++)));
            }

            // down, right
            for (int i = posX, j = posY; i < 8; i++)
            {
                legalMoves.Add(((byte)i, (byte)(j++)));
            }

            return legalMoves;
        }
    }
}