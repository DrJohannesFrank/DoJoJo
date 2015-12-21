using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dojo.VierGewinnt.Core;
using NUnit.Framework;

namespace Dojo.VierGewinnt.Tests
{
    [TestFixture]
    public class SpielFeldTests
    {
        [Test]
        public void FeldBelegtVon_ValideKoordinaten_LeeresSpielfeld()
        {
            var spielFeld = new Spielfeld();

            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    Assert.That(spielFeld.FeldIstBelegt(i, j), Is.EqualTo(Spieler.Niemand));
                }
            }
        }

        [Test]
        public void FieldBelegtVon_KoordinatenAußerhalbDesSpielfeldes_AttributeException()
        {
            var spielFeld = new Spielfeld();

            Assert.That(spielFeld.FeldIstBelegt(8,7), Throws.ArgumentException);
            Assert.That(spielFeld.FeldIstBelegt(7,8), Throws.ArgumentException);
        }

        [Test]
        public void SetzeSpalte_Spieler1Setzt_BelegtVonSpieler1()
        {
            var spielFeld = new Spielfeld();

            spielFeld.SetzeSpalte(Spieler.Spieler1, 3);
            Assert.That(spielFeld.FeldIstBelegt(0,3), Is.EqualTo(Spieler.Spieler1));
            Assert.That(spielFeld.FeldIstBelegt(1,3), Is.EqualTo(Spieler.Niemand));
        }

        [Test]
        public void SetzeSpalte_Spieler1Setzt2xSelbeSpalte_2FelderÜbereinanderBelegt()
        {
            var spielFeld = new Spielfeld();

            spielFeld.SetzeSpalte(Spieler.Spieler1, 3);
            spielFeld.SetzeSpalte(Spieler.Spieler1, 3);
            Assert.That(spielFeld.FeldIstBelegt(1, 3), Is.EqualTo(Spieler.Spieler1));
        }


    }
}
