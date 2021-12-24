using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleChessCSharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Console.InputEncoding = Encoding.ASCII;
            Console.OutputEncoding = Encoding.UTF8;
            Chess.RenderBoard();
            Console.ReadKey();
        }
    }
}