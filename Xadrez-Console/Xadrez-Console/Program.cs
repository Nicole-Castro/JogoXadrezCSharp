using tabuleiro;
using xadrez;

namespace Xadrez_Console;

class Program
{
    static void Main(string[] args)
    {
        PosicaoXadrez pos = new PosicaoXadrez('c',7); 
        System.Console.WriteLine(pos);
        Console.WriteLine(pos.toPosicao());
        System.Console.ReadLine();
    }
}
