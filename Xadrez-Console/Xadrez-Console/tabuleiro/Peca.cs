

namespace tabuleiro
{
    public class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QtdMovimentos { get; protected set; }
        public Tabuleiro Tab { get; protected set; }

        public Peca(Posicao posicao, Tabuleiro tabuleiro, Cor cor){
            Posicao = posicao;
            Cor = cor;
            QtdMovimentos = 0;
            Tab = tabuleiro;
        }
    }
}