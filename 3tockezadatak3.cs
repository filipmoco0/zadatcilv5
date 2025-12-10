using System;
using System.Collections.Generic;

struct Nastavnik
{
    public string ime;
    public string prezime;
}

struct Kolegij
{
    public int id;
    public string naziv;
    public List<Nastavnik> lNositeljKolegija;
    public int ectsBodovi;
    public int semestar;
}

class Program
{
    static void Main()
    {
        Nastavnik n1 = new Nastavnik { ime = "Marko", prezime = "Marković" };
        Nastavnik n2 = new Nastavnik { ime = "Ivana", prezime = "Ivić" };

        Kolegij k1 = new Kolegij
        {
            id = 1,
            naziv = "Osnove programiranja",
            ectsBodovi = 6,
            semestar = 1,
            lNositeljKolegija = new List<Nastavnik> { n1 }
        };

        Kolegij k2 = new Kolegij
        {
            id = 2,
            naziv = "Matematika 1",
            ectsBodovi = 7,
            semestar = 1,
            lNositeljKolegija = new List<Nastavnik> { n2 }
        };

        List<Kolegij> lKolegiji = new List<Kolegij> { k1, k2 };

        Console.WriteLine("----- SVI KOLEGIJI -----");
        foreach (var k in lKolegiji)
            IspisiKolegij(k);

        Console.WriteLine("----- TRAŽENJE KOLEGIJA -----");
        PronadjiKolegij(lKolegiji, 1);
        PronadjiKolegij(lKolegiji, 99);
    }

    static void IspisiKolegij(Kolegij k)
    {
        Console.WriteLine($"ID: {k.id}");
        Console.WriteLine($"Naziv: {k.naziv}");
        Console.WriteLine($"ECTS: {k.ectsBodovi}");
        Console.WriteLine($"Semestar: {k.semestar}");
        Console.WriteLine("Nositelji:");
        foreach (var n in k.lNositeljKolegija)
            Console.WriteLine($"  {n.ime} {n.prezime}");
        Console.WriteLine();
    }

    static void PronadjiKolegij(List<Kolegij> lista, int trazeniId)
    {
        var found = lista.FindAll(k => k.id == trazeniId);

        if (found.Count == 0)
        {
            Console.WriteLine($"Kolegij s ID {trazeniId} ne postoji.");
            return;
        }

        foreach (var k in found)
            IspisiKolegij(k);
    }
}
