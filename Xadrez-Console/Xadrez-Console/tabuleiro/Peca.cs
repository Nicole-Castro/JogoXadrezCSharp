

namespace tabuleiro
{
    abstract class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QtdMovimentos { get; protected set; }
        public Tabuleiro Tab { get; protected set; }

        public Peca(Tabuleiro tabuleiro, Cor cor){
            Posicao = null;
            Cor = cor;
            QtdMovimentos = 0;
            Tab = tabuleiro;
        }

        public void IncrementarQtdMovimentos(){
            QtdMovimentos++;
        }

        public abstract bool[,] MovimentosPossiveis();
    }
}