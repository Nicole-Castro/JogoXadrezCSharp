﻿using tabuleiro;
using xadrez;

namespace Xadrez_Console;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            PartidaDeXadrez partida = new PartidaDeXadrez();
            while (!partida.Terminada)
            {
                try
                {
                    Console.Clear();
                    Tela.ImprimirPartida(partida);
                    System.Console.WriteLine();
                    Console.Write("Origem: ");
                    Posicao origem = Tela.LerPosicaoXadrez().ToPosicao();
                    partida.ValidarPosicaoOrigem(origem);
                    bool[,] posicoesPossiveis = partida.Tab.Peca(origem).MovimentosPossiveis();

                    Console.Clear();
                    Tela.ImprimirTabuleiro(partida.Tab, posicoesPossiveis);
                    System.Console.WriteLine();
                    Console.Write("Destino: ");
                    Posicao destino = Tela.LerPosicaoXadrez().ToPosicao();
                    partida.ValidarPosicaoDestino(origem,destino);
                    partida.RealizaJogada(origem, destino);
                    
                }
                catch (TabuleiroException e){
                    Console.WriteLine(e.Message);
                    Console.ReadLine();
                }
            }
            Console.Clear();
            Tela.ImprimirPartida(partida);

        }
        catch (TabuleiroException e)
        {
            Console.WriteLine(e.Message);
        }
        //System.Console.ReadLine();


    }
}
