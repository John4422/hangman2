using System.Diagnostics.Contracts;

namespace hangman2
{
    internal class Program
    {
        int fail = 0;
        public static void Drawhang(int stage)
        {
            if (stage == 0)
            {
                Console.WriteLine("+---+");
                Console.WriteLine("|   |");
                Console.WriteLine("    |");
                Console.WriteLine("    |");
                Console.WriteLine("    |");
                Console.WriteLine("    |");
              Console.WriteLine("=========");
            }
            if (stage == 1)
            {
                "+---+"
                "|   |"
                "O   |"
                "    |"
                "    |"
                "    |"
              =========
            }
        }
        static void Main(string[] args)
        {
            
        }
    }
}