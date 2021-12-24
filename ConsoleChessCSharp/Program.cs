namespace ConsoleChessCSharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Chess chess = new();
            chess.InitBoard();

            Console.ReadKey();
        }
    }
}