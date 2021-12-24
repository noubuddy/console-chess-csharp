namespace ConsoleChessCSharp
{
    public class Chess
    {
        private static readonly char[] letters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };
        static readonly byte size = 8;
        private static char[,]? chessboard;
        private readonly char emptyCell = ' ';
        private bool isInit;
        private bool isEmptyBoard = false;
        public Dictionary<string, char> pieces = Pieces();
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
        public void InitBoard()
        {
            isInit = true;
            const string top = " --------------------------------";
            chessboard = new char[size, size];

            // Assign an empty field for all cells
            for (int i = 0; i < chessboard.GetLength(0); i++)
                for (int j = 0; j < chessboard.GetLength(1); j++)
                    chessboard[i, j] = emptyCell;


            // Assign a character of figure for not empty cells
            if (!isEmptyBoard)
            {
                foreach (KeyValuePair<string, char> cell in pieces)
                {
                    GetPosition(cell.Key, out byte posX, out byte posY);
                    chessboard[posX, posY] = cell.Value != emptyCell ? cell.Value : emptyCell;
                }
            }

            // Draw a chessboard in console
            for (int y = 0; y < size; y++)
            {
                Console.WriteLine("  " + top);
                Console.Write(" " + (size - y));
                for (int x = 0; x < size; x++)
                    Console.Write("|" + (chessboard[x, y] != emptyCell ? " " + chessboard[x, y] + " " : "   "));
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
        public void AddPiece(char piece, string cell)
        {
            pieces.Add(cell, piece);
        }

        // DOESN'T WORKS
        // Move a piece to a specific cell
        public void Move(string from, string to)
        {
            pieces[to] = pieces[from];
            pieces.Remove(from);
        }

        // List of pieces, assigned to corresponding cells
        private static Dictionary<string, char> Pieces()
        {
            Dictionary<string, char> dict = new();

            dict["A1"] = 'r';
            dict["B1"] = 'k';
            dict["C1"] = 'b';
            dict["D1"] = 'q';
            dict["E1"] = 'K';
            dict["F1"] = 'b';
            dict["G1"] = 'k';
            dict["H1"] = 'r';

            dict["A2"] = 'p';
            dict["B2"] = 'p';
            dict["C2"] = 'p';
            dict["D2"] = 'p';
            dict["E2"] = 'p';
            dict["F2"] = 'p';
            dict["G2"] = 'p';
            dict["H2"] = 'p';

            return dict;
        }
    }
}
