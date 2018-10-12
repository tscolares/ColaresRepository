using System;
using System.Collections.Generic;
using System.Text;

namespace JeuDechecsConsole.tabuleiro
{
    public class TabuleiroException : Exception
    {
        public TabuleiroException(string msg) : base (msg)
        {

        }
    }
}
