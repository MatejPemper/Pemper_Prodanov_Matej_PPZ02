using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pemper_Prodanov_Matej_PPZ02
{
    internal class Alkohol
    {
        string naziv, kolicina, pakiranje;
        int cijena;
        int postotak;
        private string text1;
        private string text2;
        private string text3;
        private string text4;
        private int value;

        public Alkohol(string naziv, string kolicina, string pakiranje, int cijena, int postotak)
        {
            this.naziv = naziv;
            this.kolicina = kolicina;
            this.pakiranje = pakiranje;
            this.cijena = cijena;
            this.postotak = postotak;
        }

        public Alkohol(string text1, string text2, string text3, string text4, int value)
        {
            this.text1 = text1;
            this.text2 = text2;
            this.text3 = text3;
            this.text4 = text4;
            this.value = value;
        }

        public override string ToString()
        {
            return "Naziv: " + this.naziv + "\n količina: " + this.kolicina + "\n pakiranje: " + this.pakiranje + "\n postotak: " + this.postotak + "\n cijena: " + this.cijena;
        }

        public string Naziv { get => naziv; set => naziv = value; }
        public string Kolicina { get => kolicina; set => kolicina = value; }
        public string Pakiranje { get => pakiranje; set => pakiranje = value; }
        public int Cijena { get => cijena; set => cijena = value; }
        public int Postotak { get => postotak; set => postotak = value; }

    }
}
