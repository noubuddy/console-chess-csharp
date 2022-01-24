using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleChessCSharp.Pieces
{
    public interface IPiece
    {
        public List<(byte, byte)> legalMoves(string position);
    }
}
