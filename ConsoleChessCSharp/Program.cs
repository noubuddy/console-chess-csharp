namespace ConsoleChessCSharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Chess chess = new();

            while (true)
            {
                chess.InitBoard();

                Console.Write("\n\nFrom: ");
                string from = Console.ReadLine()!.ToUpper();

                chess.InitBoard();

                Console.Write("\n\nTo: ");
                string to = Console.ReadLine()!.ToUpper();
                
                chess.Move(from, to);

                chess.InitBoard();
            }
        }
    }
}