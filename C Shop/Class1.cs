using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Shop
{
    public class Prodotto
    {
        public int Codice;
        public string Nome;
        public string Descrizione;
        public int Prezzo;
        public int Iva;

        
        
        

        public Prodotto(int Codice, string Nome, string Descrizione, int Prezzo, int Iva)
        {
            this.Codice = Codice;
            this.Nome = Nome;
            this.Descrizione = Descrizione;
            this.Prezzo = Prezzo;
            this.Iva = Iva;
            

        }
        public void StampaProdotto()
        {
            Console.WriteLine("il codice del prodotto è: " + Codice + " " + Nome);
            Console.WriteLine(" il prezzo base è: " + Prezzo + "$");
            Console.WriteLine("  il prezzo comprensivo di iva è: " + PrezzoConIva(Prezzo, Iva) + "$");
        }
      public int PrezzoConIva(int Prezzo, int iva)
        {
            int IVA = (Prezzo * iva) / 100;
           int PrezzoFinale = Prezzo + IVA;
            return PrezzoFinale;
        }
      
       
    }   
}
