using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tabuleiro
{
    public class Tabuleiro
    {
        public int Linhas { get; set; }
        public int Colunas { get; set;}
        private Peca[,] Pecas;

        public Tabuleiro(int linhas, int colunas){
            Linhas = linhas;
            Colunas = colunas;
            Pecas = new Peca[linhas, colunas];
        }
    }
}