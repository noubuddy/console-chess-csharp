using ConsoleChessCSharp.Pieces;

namespace ConsoleChessCSharp
{
	public class Chess
	{
		// Convert position to array coordinate values
		public static void GetPosition(string cellPosition, out byte posX, out byte posY)
		{
			char x = char.ToLower(cellPosition[0]);
			char y = cellPosition[1];

			switch(x)
			{
				case 'a':
					posX = 0;
					break;
				case 'b':
					posX = 1;
					break;
				case 'c':
					posX = 2;
					break;
				case 'd':
					posX = 3;
					break;
				case 'e':
					posX = 4;
					break;
				case 'f':
					posX = 5;
					break;
				case 'g':
					posX = 6;
					break;
				case 'h':
					posX = 7;
					break;
				default:
					posX = 255;
					break;
			}
			switch(y)
			{
				case '1':
					posY = 7;
					break;
				case '2':
					posY = 6;
					break;
				case '3':
					posY = 5;
					break;
				case '4':
					posY = 4;
					break;
				case '5':
					posY = 3;
					break;
				case '6':
					posY = 2;
					break;
				case '7':
					posY = 1;
					break;
				case '8':
					posY = 0;
					break;
				default:
					posY = 255;
					break;
			}
		}



		// Move a piece to a specific cell
		public void Move(string from, string to)
		{
			var cellFrom = PieceList.Where(t => t.Position.Contains(from)).First();

			PieceList.Add(Pieces.Pieces.AddNewPiece(cellFrom, to));
			PieceList.Remove(cellFrom);
		}


        // List of all the pieces
        public static readonly List<Pieces.Pieces> PieceList = new()
		{
			// White pieces
			new Pawn('p', Pieces.Pieces.white, "A2"),
			new Pawn('p', Pieces.Pieces.white, "B2"),
			new Pawn('p', Pieces.Pieces.white, "C2"),
			new Pawn('p', Pieces.Pieces.white, "D2"),
			new Pawn('p', Pieces.Pieces.white, "E2"),
			new Pawn('p', Pieces.Pieces.white, "F2"),
			new Pawn('p', Pieces.Pieces.white, "G2"),
			new Pawn('p', Pieces.Pieces.white, "H2"),

			new Rook('r', Pieces.Pieces.white, "A1"),
			new Rook('r', Pieces.Pieces.white, "H1"),

			new Knight('k', Pieces.Pieces.white, "B1"),
			new Knight('k', Pieces.Pieces.white, "G1"),

			new Bishop('b', Pieces.Pieces.white, "C1"),
			new Bishop('b', Pieces.Pieces.white, "F1"),

			new Queen('q', Pieces.Pieces.white, "E1"),
			new King('K', Pieces.Pieces.white, "D1"),

			// Black pieces
			new Pawn('p', Pieces.Pieces.black, "A7"),
			new Pawn('p', Pieces.Pieces.black, "B7"),
			new Pawn('p', Pieces.Pieces.black, "C7"),
			new Pawn('p', Pieces.Pieces.black, "D7"),
			new Pawn('p', Pieces.Pieces.black, "E7"),
			new Pawn('p', Pieces.Pieces.black, "F7"),
			new Pawn('p', Pieces.Pieces.black, "G7"),
			new Pawn('p', Pieces.Pieces.black, "H7"),

			new Rook('r', Pieces.Pieces.black, "A8"),
			new Rook('r', Pieces.Pieces.black, "H8"),

			new Knight('k', Pieces.Pieces.black, "B8"),
			new Knight('k', Pieces.Pieces.black, "G8"),

			new Bishop('b', Pieces.Pieces.black, "C8"),
			new Bishop('b', Pieces.Pieces.black, "F8"),

			new Queen('q', Pieces.Pieces.black, "E8"),
			new King('K', Pieces.Pieces.black, "D8"),
		};
	}
}
