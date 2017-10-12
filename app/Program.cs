using static System.Console;
using Library;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine($"Suma z dodawania 19 i 32 to {new Thing().Get(19, 32)}!");
        }
    }
}
