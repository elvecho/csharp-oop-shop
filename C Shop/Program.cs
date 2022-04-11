// See https://aka.ms/new-console-template for more information

using C_Shop;



Console.WriteLine("inserisci il nome");
string nome = Console.ReadLine();

string Descrizione = "ciao";
int Prezzo = 12;
int Iva = 22;
int disponibilitàS = 10;
int disponibilitàp = 20;
int disponibilitàT= 15;
int NumeroTabletAcquistati2 = 0;
int NumeropcAcquistati2 = 0;
int NumeroSmartphoneAcquistati2 = 0;

Random Random = new Random();
int codice = Random.Next(9999999);
Console.WriteLine(codice);


Prodotto NuovoProdotto = new Prodotto(codice, nome, Descrizione, Prezzo, Iva);
NuovoProdotto.PrezzoConIva(Prezzo, Iva);

NuovoProdotto.StampaProdotto();

Magazzino NuovoMagazzino = new Magazzino(disponibilitàS, disponibilitàp, disponibilitàT, NumeroTabletAcquistati2, NumeropcAcquistati2, NumeroSmartphoneAcquistati2);

for(int i = 0; i < 35; i++)
{
    Console.WriteLine("inserisci il nome del prodotto, a disposizione abbiamo: smartphone, pc, tablet");
    string nomeProdotto = Console.ReadLine();
    if(nomeProdotto == "smartphone")
    {
        NuovoMagazzino.StampaMagazzino();
        Random Codice2 = new Random();
        int CodiceSmartphone = Codice2.Next(9999999);
        string Nome = "Smartphone";
        string Descrizione2 = "ciao";
        int PrezzoSmartPhone = 989;
        
        Prodotto Smartphone = new Prodotto(CodiceSmartphone, Nome, Descrizione2, PrezzoSmartPhone, Iva);
        Smartphone.StampaProdotto();
        NuovoMagazzino.ascquistoSmartphone();
        Console.WriteLine("vuoi acquistare altro? (si/ no)");
        string risposta = Console.ReadLine();
        if (risposta == "no")
        {
            break;
        }
       
        
        
    }if (nomeProdotto == "pc")
    {
        NuovoMagazzino.StampaMagazzino();
        Random Codice2 = new Random();
        int CodiceSmartphone = Codice2.Next(9999999);
        string Nome = "Pc";
        string Descrizione2 = "ciao";
        int PrezzoPC = 1499;

        Prodotto Pc = new Prodotto(CodiceSmartphone, Nome, Descrizione2, PrezzoPC, Iva);
        Pc.StampaProdotto();
        NuovoMagazzino.ascquistoPC();
        Console.WriteLine("vuoi acquistare altro? (si/ no)");
        string risposta = Console.ReadLine();
        if (risposta == "no")
        {
            break;
        }
    }
    if (nomeProdotto == "tablet")
    {
        NuovoMagazzino.StampaMagazzino();
        Random Codice2 = new Random();
        int CodiceSmartphone = Codice2.Next(9999999);
        string Nome = "Pc";
        string Descrizione2 = "ciao";
        int PrezzoPC = 560;

        Prodotto Tablet = new Prodotto(CodiceSmartphone, Nome, Descrizione2, PrezzoPC, Iva);
        Tablet.StampaProdotto();
        NuovoMagazzino.ascquistoTablet();
        Console.WriteLine("vuoi acquistare altro? (si/ no)");
        string risposta = Console.ReadLine();
        if (risposta == "no")
        {
            break;
        }
    }
    
        
    }
NuovoMagazzino.StampaMagazzino();


