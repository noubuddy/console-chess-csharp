namespace ConsoleChessCSharp.Pieces
{
    public class Bishop : Pieces
    {
        public Bishop(char piece, string color, string position) : base(piece, color, position)
        {
        }

        public override List<(byte, byte)> LegalMoves(string position)
        {
            List<(byte, byte)> legalMoves = new();

            Chess.GetPosition(position, out byte posX, out byte posY);
            
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