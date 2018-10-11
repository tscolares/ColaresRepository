﻿
namespace JeuDechecsConsole.tabuleiro
{
    public class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QtdeMovimentos { get; protected set; }
        public Tabuleiro Tab { get; set; }

        public Peca(Posicao posicao, Tabuleiro tab, Cor cor)
        {
            this.Posicao = posicao;
            this.Tab = tab;
            this.Cor = cor;
            this.QtdeMovimentos = 0;

        }
    }
}
