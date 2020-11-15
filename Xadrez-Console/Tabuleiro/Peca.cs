
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
        public void decrementarQtdMovimento()
        {
            QtdMovimentos--;
        }
        public bool existeMovimentosPossiveis()
        {
            bool[,] mat = movimentosPossiveis();
            for(int i=0; i<tab.Linha; i++)
            {
                for(int j=0; j<tab.Coluna; j++)
                {
                    if (mat[i, j])
                    {
                        return true;
                    }
                }
            }
            return false;

        }

        public bool podeMoverPara(Posicao pos)
        {
            return movimentosPossiveis()[pos.Linha, pos.Coluna];
        }

        public abstract bool[,] movimentosPossiveis();
        

        
    }
}
