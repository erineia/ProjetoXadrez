using tabuleiro;

namespace xadrez
{
    class Rei : Peca
    {
        public Rei(Tabuleiro tab, Cor cor) : base(cor, tab)
        {

        }
        public override string ToString()
        {
            return "R";
        }
        private bool podeMover(Posicao pos)
        {
            Peca p = tab.peca(pos);
            return p == null || p.cor != cor;
        }

        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[tab.Linha, tab.Coluna];

            Posicao pos = new Posicao(0,0);

            //ACIMA
            pos.definirValores(posicao.Linha - 1, posicao.Coluna);
            if(tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            //NORDESTE
            pos.definirValores(posicao.Linha - 1, posicao.Coluna +1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            //DIREITA
            pos.definirValores(posicao.Linha, posicao.Coluna + 1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            //SUDESTE
            pos.definirValores(posicao.Linha +1, posicao.Coluna + 1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            //ABAIXO
            pos.definirValores(posicao.Linha +1, posicao.Coluna);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            //SUDOESTE
            pos.definirValores(posicao.Linha +1, posicao.Coluna -1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            //ESQUERDA
            pos.definirValores(posicao.Linha, posicao.Coluna - 1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            //NOROESTE
            pos.definirValores(posicao.Linha - 1, posicao.Coluna -1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            return mat;
        }

    }
}
