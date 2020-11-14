
namespace tabuleiro
{
   abstract class Peca
    {
        public Posicao posicao{ get; set; }
        public Cor cor { get; protected set; }
        public int QtdMovimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        public Peca(Cor cor, Tabuleiro tab)
        {
            this.posicao = null;
            this.cor = cor;
            this.tab = tab;
            QtdMovimentos = 0 ;

        }

        public void incrementarQtdMovimento()
        {
            QtdMovimentos++;
        }

        public abstract bool[,] movimentosPossiveis();
        

        
    }
}
