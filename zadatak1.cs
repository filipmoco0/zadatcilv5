using System;
using System.Collections.Generic;

struct Automobil
{
    public string marka;
    public int godinaProizvodnje;
    public int obujamMotora;     // u cm3
    public int kilometri;

    // Funkcija za ažuriranje kilometara
    public void AzurirajKilometre(int noviKm)
    {
        kilometri = noviKm;
    }

    // Funkcija za usporedbu obujma motora
    public void UsporediObujam(Automobil drugi)
    {
        if (obujamMotora == drugi.obujamMotora)
            Console.WriteLine("Jednak obujam motora.");
        else if (obujamMotora > drugi.obujamMotora)
            Console.WriteLine("Prvi automobil ima veći obujam.");
        else
            Console.WriteLine("Drugi automobil ima veći obujam.");
    }

    // Funkcija koja vraća starost auta
    public int Starost()
    {
        return DateTime.Now.Year - godinaProizvodnje;
    }
}

class Program
{
    static void Main()
    {
        // A) KREIRANJE AUTOMOBILA
        Automobil a1 = new Automobil { marka = "Audi", godinaProizvodnje = 2015, obujamMotora = 2000, kilometri = 150000 };
        Automobil a2 = new Automobil { marka = "BMW", godinaProizvodnje = 2010, obujamMotora = 2500, kilometri = 220000 };
        Automobil a3 = new Automobil { marka = "Opel", godinaProizvodnje = 2018, obujamMotora = 1600, kilometri = 90000 };

        // Usporedba prva dva
        a1.UsporediObujam(a2);

        // Ažuriranje trećeg i usporedba s prvim
        a3.AzurirajKilometre(95000);
        a3.UsporediObujam(a1);

        // Spremanje u listu
        List<Automobil> automobili = new List<Automobil> { a1, a2, a3 };


        // B) ISPIS AUTA STARijih OD 6 GODINA I OB. MOTORA < 2200 cm3
        Console.WriteLine("\nAutomobili stariji od 6 godina i s obujmom motora < 2200 cm3:");

        foreach (var auto in automobili)
        {
            if (auto.Starost() > 6 && auto.obujamMotora < 2200)
            {
                Console.WriteLine($"{auto.marka} - Godina: {auto.godinaProizvodnje}, Obujam: {auto.obujamMotora} cm3, Starost: {auto.Starost()} god");
            }
        }
    }
}
