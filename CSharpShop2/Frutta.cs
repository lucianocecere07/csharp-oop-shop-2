using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpShop2
{
    public class Frutta : Prodotto
    {
        //proprietà
        private int pezzi;

        //costruttori
        public Frutta(string nome, string descrizione, double prezzo, int iva, int pezzi) : base(nome, descrizione, prezzo, iva)
        {
            this.pezzi = pezzi;
        }

        //getter
        public int GetPezzi() 
        { 
            return this.pezzi; 
        }


    }    
}
