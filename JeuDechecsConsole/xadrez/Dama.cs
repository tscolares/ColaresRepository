﻿using JeuDechecsConsole.tabuleiro;

namespace JeuDechecsConsole.xadrez
{
    public class Dama : Peca
    {
        public Dama(Tabuleiro tab, Cor cor) : base(tab, cor)
        {
        }

        public override string ToString()
        {
            return "D";
        }

        private bool PodeMover(Posicao pos)
        {
            Peca p = Tab.Peca(pos);
            return p == null || p.Cor != this.Cor;
        }

        public override bool[,] MovimentosPossiveis()
        {
            bool[,] mat = new bool[Tab.Linhas, Tab.Colunas];

            Posicao pos = new Posicao(0, 0);

            //Acima
            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna);
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab.Peca(pos) != null && Tab.Peca(pos).Cor != this.Cor)
                {
                    break;
                }
                pos.Linha = pos.Linha - 1;
            }

            //Abaixo
            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna);
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab.Peca(pos) != null && Tab.Peca(pos).Cor != this.Cor)
                {
                    break;
                }
                pos.Linha = pos.Linha + 1;
            }

            //Direita
            pos.DefinirValores(Posicao.Linha, Posicao.Coluna + 1);
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab.Peca(pos) != null && Tab.Peca(pos).Cor != this.Cor)
                {
                    break;
                }
                pos.Coluna = pos.Coluna + 1;
            }

            //Esquerda
            pos.DefinirValores(Posicao.Linha, Posicao.Coluna - 1);
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab.Peca(pos) != null && Tab.Peca(pos).Cor != this.Cor)
                {
                    break;
                }
                pos.Coluna = pos.Coluna - 1;
            }

            //Noroeste
            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna - 1);
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;

                if (Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor)
                {
                    break;
                }
                pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna - 1);
            }

            //Nordeste
            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna + 1);
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;

                if (Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor)
                {
                    break;
                }
                pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna + 1);
            }

            //Sudeste
            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna + 1);
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;

                if (Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor)
                {
                    break;
                }
                pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna + 1);
            }

            //Sudoeste
            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna - 1);
            while (Tab.PosicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;

                if (Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor)
                {
                    break;
                }
                pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna - 1);
            }

            return mat;
        }
    }
}
