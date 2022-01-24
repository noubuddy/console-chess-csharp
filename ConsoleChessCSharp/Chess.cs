using ConsoleChessCSharp.Pieces;

namespace ConsoleChessCSharp
{
	public class Chess
	{
		public static readonly char[] letters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };
		public static readonly byte size = 8;
		public static char[,]? chessboard;
		public static bool[,]? isWhite;
		public static readonly char emptyCell = ' ';
		public static bool isInit;
		public static bool isEmptyBoard = false;
		public static Dictionary<string, Tuple<char, string>> pieces = Pieces();
		public bool IsEmptyBoard
		{
			set
			{
				if (isInit == true)
					throw new Exception("Chessboard has already been initialized");
				else
					isEmptyBoard = value;
			}
		}


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



		// Add a piece to specific cell
		public void AddPiece(string cell, Tuple<char, string> value)
		{
			pieces.Add(cell, value);
		}



		// Move a piece to a specific cell
		public void Move(string from, string to)
		{
			pieces[to] = pieces[from];
			pieces.Remove(from);
		}



		// List of pieces, assigned to corresponding cells
		private static Dictionary<string, Tuple<char, string>> Pieces()
		{
            Dictionary<string, Tuple<char, string>> pieces = new()
            {

                // Black pieces
                ["A8"] = new Tuple<char, string>('r', "black"),
                ["B8"] = new Tuple<char, string>('k', "black"),
                ["C8"] = new Tuple<char, string>('b', "black"),
                ["D8"] = new Tuple<char, string>('q', "black"),
                ["E8"] = new Tuple<char, string>('K', "black"),
                ["F8"] = new Tuple<char, string>('b', "black"),
                ["G8"] = new Tuple<char, string>('k', "black"),
                ["H8"] = new Tuple<char, string>('r', "black"),

                ["A7"] = new Tuple<char, string>('p', "black"),
                ["B7"] = new Tuple<char, string>('p', "black"),
                ["C7"] = new Tuple<char, string>('p', "black"),
                ["D7"] = new Tuple<char, string>('p', "black"),
                ["E7"] = new Tuple<char, string>('p', "black"),
                ["F7"] = new Tuple<char, string>('p', "black"),
                ["G7"] = new Tuple<char, string>('p', "black"),
                ["H7"] = new Tuple<char, string>('p', "black"),

                // White pieces
                ["A1"] = new Tuple<char, string>('r', "white"),
                ["B1"] = new Tuple<char, string>('k', "white"),
                ["C1"] = new Tuple<char, string>('b', "white"),
                ["D1"] = new Tuple<char, string>('q', "white"),
                ["E1"] = new Tuple<char, string>('K', "white"),
                ["F1"] = new Tuple<char, string>('b', "white"),
                ["G1"] = new Tuple<char, string>('k', "white"),
                ["H1"] = new Tuple<char, string>('r', "white"),

                ["A2"] = new Tuple<char, string>('p', "white"),
                ["B2"] = new Tuple<char, string>('p', "white"),
                ["C2"] = new Tuple<char, string>('p', "white"),
                ["D2"] = new Tuple<char, string>('p', "white"),
                ["E2"] = new Tuple<char, string>('p', "white"),
                ["F2"] = new Tuple<char, string>('p', "white"),
                ["G2"] = new Tuple<char, string>('p', "white"),
                ["H2"] = new Tuple<char, string>('p', "white")
            };

            return pieces;
		}
	}
}
