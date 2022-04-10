using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Shop
{
    public class Magazzino
    {
        public int disponibiltàSmartphone;
        public int disponibiltàPc;
        public int disponibiltàTablet;
        public int NumeroTabletAcquistati;
        public int NumeropcAcquistati;
        public int NumeroSmartphoneAcquistati;

        public Magazzino(int disponibiltàSmartphone, int disponibiltàPc, int disponibiltàTablet, int numeroTabletacquistati, int numeropcAcquistati, int NumeroSmartphoneAcquistati)
        {
            this.disponibiltàSmartphone = disponibiltàSmartphone;
            this.disponibiltàPc = disponibiltàPc;
            this.disponibiltàTablet = disponibiltàTablet;
            this.NumeroTabletAcquistati = numeroTabletacquistati;
            this.NumeropcAcquistati = numeropcAcquistati;
            this.NumeroSmartphoneAcquistati = NumeroSmartphoneAcquistati;
        }

        public void StampaMagazzino()
        {
            Console.WriteLine("questa è la disponibiltà del nostro magazzino: ");
            Console.WriteLine("il numero di smartphone è: " + disponibiltàSmartphone);
            Console.WriteLine("il numero di Pc è: " + disponibiltàPc);
            Console.WriteLine(" il numero di tablet è: " + disponibiltàTablet);

        }
        public void ascquistoTablet()
        {
            if (NumeroTabletAcquistati < disponibiltàTablet)
            {
                NumeroTabletAcquistati++;
                disponibiltàTablet--;
            }
            else
            {
                Console.WriteLine("mi spiace non ci sono più tablet disponibili");
            }
        }
        public void ascquistoPC()
        {
            if (NumeropcAcquistati < disponibiltàPc)
            {
                NumeropcAcquistati++;
                disponibiltàPc--;
            }
            else
            {
                Console.WriteLine("mi spiace non ci sono più pc disponibili");
            }
        }
        public void ascquistoSmartphone()
        {
            if (NumeroSmartphoneAcquistati < disponibiltàSmartphone)
            {
                NumeroSmartphoneAcquistati++;
                disponibiltàSmartphone--;
            }
            else
            {
                Console.WriteLine("mi spiace non ci sono più smartphone disponibili");
            }



        }

    }
}
        

