﻿using JeuDechecsConsole.tabuleiro;
using JeuDechecsConsole.xadrez;
using System;

namespace JeuDechecsConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            PosicaoXadrez pos = new PosicaoXadrez('c', 7);

            Console.WriteLine(pos);

            Console.WriteLine(pos.ToPosicao());

            Console.ReadLine();
        }
    }
}
