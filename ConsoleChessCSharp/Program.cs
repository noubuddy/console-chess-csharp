using ConsoleChessCSharp.Pieces;
using System.Collections.Generic;
using System.Runtime;

namespace ConsoleChessCSharp
{
	public class Program
	{
		public static string? from;
		public static void Main(string[] args)
		{
			Draw board = new();
			Chess chess = new();

			while (true)
			{
				from = null;

				board.Init();

				Console.Write("\n\nFrom: ");
				from = Console.ReadLine()!.ToUpper();

                board.Init();

				Console.Write("\n\nTo: ");
				string to = Console.ReadLine()!.ToUpper();

				chess.Move(from, to);

				board.Init();
			}
		}
	}
}
