namespace ConsoleChessCSharp
{
#nullable disable
    public class Program
    {
        public static string from;
        public static void Main(string[] args)
        {
            Draw board = new();

            while (true)
            {
                board.Init();

                Console.Write("\n\nFrom: ");
                from = Console.ReadLine().ToUpper();

                board.Init();

                Console.Write("\n\nTo: ");
                string to = Console.ReadLine().ToUpper();

                Chess.Move(from, to);

                from = null;

                board.Init();
            }
        }
    }
}
