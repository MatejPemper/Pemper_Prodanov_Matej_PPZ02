using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pemper_Prodanov_Matej_PPZ02
{
    internal class Gazirano
    {
        string naziv, kolicina, pakiranje;
        int cijena;

        public Gazirano(string naziv, string kolicina, string pakiranje, int cijena)
        {
            this.naziv = naziv;
            this.kolicina = kolicina;
            this.pakiranje = pakiranje;
            this.cijena = cijena;
        }

        public Gazirano(string text1, string text2, string text3, string text4)
        {
            Text1 = text1;
            Text2 = text2;
            Text3 = text3;
            Text4 = text4;
        }

        public override string ToString()
        {
            return "Naziv: " + this.naziv + "\n količina: " + this.kolicina + "\n pakiranje: " + this.pakiranje + "\n cijena: " + this.cijena;
        }

        public string Naziv { get => naziv; set => naziv = value; }
        public string Kolicina { get => kolicina; set => kolicina = value; }
        public string Pakiranje { get => pakiranje; set => pakiranje = value; }
        public int Cijena { get => cijena; set => cijena = value; }
        public string Text1 { get; }
        public string Text2 { get; }
        public string Text3 { get; }
        public string Text4 { get; }
    }
}
