namespace ConsoleChessCSharp
{
    public class Chess
    {
        private static readonly string[] letters = { "A", "B", "C", "D", "E", "F", "G", "H" };
        static readonly int size = 8;
        private static bool[,]? chessboard;

        public static void RenderBoard()
        {
            const string top = " ----------------------------------";
            chessboard = new bool[size, size];

            for (int i = 0; i < chessboard.GetLength(0); i++)
            {
                for (int j = 0; j < chessboard.GetLength(1); j++)
                {
                    chessboard[i, j] = true;
                }
            }
            //chessboard[4, 6] = true;

            for (int y = 0; y < size; y++)
            {
                Console.WriteLine(" " + top);
                Console.Write(" " + (size - y));
                for (int x = 0; x < size; x++)
                {
                    Console.Write("|" + (chessboard[x, y] ? " p " : "   "));
                }
                Console.WriteLine("|");
            }
            Console.Write("   ");
            for (int i = 0; i < size; i++)
            {
                Console.Write(" " + letters[i] + "  ");
            }
        }



    }
}
