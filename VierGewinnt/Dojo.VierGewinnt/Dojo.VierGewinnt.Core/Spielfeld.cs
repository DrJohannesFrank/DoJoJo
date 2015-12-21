using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dojo.VierGewinnt.Core
{
    public class Spielfeld
    {
        private Spieler[,] _alleFelder;

        public Spielfeld()
        {
            _alleFelder = new Spieler[7, 7];
        }

        public Spieler FeldIstBelegt(int row, int col)
        {
            return _alleFelder[row,col];
        }

        public void SetzeSpalte(Spieler spieler1, int i)
        {
            throw new NotImplementedException();

            // hier sollte nun in spalte i, ein stein so gesetzt werden, dass er oben drauf fällt...
        }
    }

    public enum Spieler
    {
        Niemand,
        Spieler1,
        Spieler2,
    }
}
