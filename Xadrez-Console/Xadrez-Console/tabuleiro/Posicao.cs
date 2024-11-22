
namespace tabuleiro
{
    public class Posicao
    {
        public int Linha { get; set; }
        public int Coluna { get; set; }

        public Posicao(int linha, int coluna)
        {
            Linha = linha;
            Coluna = coluna;
        }
        public void DefinirValores(int linha, int coluna){
            Linha = linha;
            Coluna = coluna;
        }
        override public string ToString(){
            return Linha + ", " + Coluna;
        }
    }
}