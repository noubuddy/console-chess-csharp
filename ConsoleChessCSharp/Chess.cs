namespace ConsoleChessCSharp
{
    public class Chess
    {
        private readonly char[] letters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };
        readonly byte size = 8;
        private char[,]? chessboard;
        private bool[,]? isWhite;
        private readonly char emptyCell = ' ';
        private bool isInit;
        private bool isEmptyBoard = false;
        public Dictionary<string, Tuple<char, string>> pieces = Pieces();
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



        // Create (draw) a chessboard
        public void Init()
        {
            Console.Clear();
            isInit = true;
            const string top = " --------------------------------";
            chessboard = new char[size, size];
            isWhite = new bool[size, size];

            // Assign an empty field for all cells
            for (int i = 0; i < chessboard.GetLength(0); i++)
                for (int j = 0; j < chessboard.GetLength(1); j++) 
                { 
                    chessboard[i, j] = emptyCell;
                }

            // Assign a character of figure for not empty cells
            if (!isEmptyBoard)
            {
                foreach (KeyValuePair<string, Tuple<char, string>> cell in pieces)
                {
                    GetPosition(cell.Key, out byte posX, out byte posY);
                    chessboard[posX, posY] = cell.Value.Item1 != emptyCell ? cell.Value.Item1 : emptyCell;
                    isWhite[posX, posY] = cell.Value.Item2 == "white";
                }
            }

            // Draw a chessboard in console
            for (int y = 0; y < size; y++)
            {
                Console.WriteLine("  " + top);
                Console.Write(" " + (size - y));
                for (int x = 0; x < size; x++) 
                {
                    Console.Write("|");
                    if (!isWhite[x, y]) 
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write(chessboard[x, y] != emptyCell ? " " + chessboard[x, y] + " " : "   ");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.Write(chessboard[x, y] != emptyCell ? " " + chessboard[x, y] + " " : "   ");
                    }
                }
                Console.WriteLine("|");
            }
            Console.WriteLine("  " + top);
            Console.Write("   ");
            for (int i = 0; i < size; i++)
                Console.Write(" " + letters[i] + "  ");
        }



        // Convert position to array coordinate values
        private void GetPosition(string cellPosition, out byte posX, out byte posY)
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
            Dictionary<string, Tuple<char, string>> pieces = new();

            // Black pieces
            pieces["A8"] = new Tuple<char, string>('r', "black");
            pieces["B8"] = new Tuple<char, string>('k', "black");
            pieces["C8"] = new Tuple<char, string>('b', "black");
            pieces["D8"] = new Tuple<char, string>('q', "black");
            pieces["E8"] = new Tuple<char, string>('K', "black");
            pieces["F8"] = new Tuple<char, string>('b', "black");
            pieces["G8"] = new Tuple<char, string>('k', "black");
            pieces["H8"] = new Tuple<char, string>('r', "black");

            pieces["A7"] = new Tuple<char, string>('p', "black");
            pieces["B7"] = new Tuple<char, string>('p', "black");
            pieces["C7"] = new Tuple<char, string>('p', "black");
            pieces["D7"] = new Tuple<char, string>('p', "black");
            pieces["E7"] = new Tuple<char, string>('p', "black");
            pieces["F7"] = new Tuple<char, string>('p', "black");
            pieces["G7"] = new Tuple<char, string>('p', "black");
            pieces["H7"] = new Tuple<char, string>('p', "black");

            // White pieces
            pieces["A1"] = new Tuple<char, string>('r', "white");
            pieces["B1"] = new Tuple<char, string>('k', "white");
            pieces["C1"] = new Tuple<char, string>('b', "white");
            pieces["D1"] = new Tuple<char, string>('q', "white");
            pieces["E1"] = new Tuple<char, string>('K', "white");
            pieces["F1"] = new Tuple<char, string>('b', "white");
            pieces["G1"] = new Tuple<char, string>('k', "white");
            pieces["H1"] = new Tuple<char, string>('r', "white");

            pieces["A2"] = new Tuple<char, string>('p', "white");
            pieces["B2"] = new Tuple<char, string>('p', "white");
            pieces["C2"] = new Tuple<char, string>('p', "white");
            pieces["D2"] = new Tuple<char, string>('p', "white");
            pieces["E2"] = new Tuple<char, string>('p', "white");
            pieces["F2"] = new Tuple<char, string>('p', "white");
            pieces["G2"] = new Tuple<char, string>('p', "white");
            pieces["H2"] = new Tuple<char, string>('p', "white");

            return pieces;
        }
    }
}
