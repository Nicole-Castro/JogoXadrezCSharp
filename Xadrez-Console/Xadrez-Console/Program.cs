﻿using tabuleiro;

namespace Xadrez_Console;

class Program
{
    static void Main(string[] args)
    {
        Posicao p = new Posicao(3,4);

        System.Console.WriteLine("Posição: " +p);
        System.Console.ReadLine();
    }
}