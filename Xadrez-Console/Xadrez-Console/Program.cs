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
                    Tela.ImprimirTabuleiro(partida.Tab);
                    System.Console.WriteLine();
                    System.Console.WriteLine("Turno: " + partida.Turno);
                    System.Console.WriteLine("Aguardando Jogada: " + partida.JogadorAtual);
                    System.Console.WriteLine();
                    Console.Write("Origem: ");
                    Posicao origem = Tela.LerPosicaoXadrez().toPosicao();
                    partida.ValidarPosicaoOrigem(origem);
                    bool[,] posicoesPossiveis = partida.Tab.Peca(origem).MovimentosPossiveis();

                    Console.Clear();
                    Tela.ImprimirTabuleiro(partida.Tab, posicoesPossiveis);
                    System.Console.WriteLine();
                    Console.Write("Destino: ");
                    Posicao destino = Tela.LerPosicaoXadrez().toPosicao();
                    partida.ValidarPosicaoDestino(origem,destino);
                    partida.RealizaJogada(origem, destino);
                }
                catch (TabuleiroException e){
                    Console.WriteLine(e.Message);
                    Console.ReadLine();
                }
            }

        }
        catch (TabuleiroException e)
        {
            Console.WriteLine(e.Message);
        }
        //System.Console.ReadLine();


    }
}
