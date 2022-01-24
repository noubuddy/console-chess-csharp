using ConsoleChessCSharp;

namespace ConsoleChessCSharp.Pieces
{
    public class Piece
    {
        public List<(byte, byte)> legalMoves(string position)
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