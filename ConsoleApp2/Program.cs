using PilotakClass;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.IO;

StreamReader sr = new StreamReader("pilotak.csv");
List<Pilota> Pilotak = new List<Pilota>();
sr.ReadLine();
while (!sr.EndOfStream)
{
    string[] adatok = sr.ReadLine().Split(";");
    if (adatok[3] == "")
    {
        Pilota sor = new Pilota(adatok[0], adatok[1], adatok[2], -1);
        Pilotak.Add(sor);
    }
    else
    {
        Pilota sor = new Pilota(adatok[0], adatok[1], adatok[2], Convert.ToInt32(adatok[3]));
        Pilotak.Add(sor);
    }         
}
//3.
Console.WriteLine($"3.Feladat: {Pilotak.Count()}");

//4.
Console.WriteLine($"4.Feladat: {Pilotak[Pilotak.Count()-1].Nev}");

//5.
Console.WriteLine("5.Feladat: ");
for (int i = 0; i < Pilotak.Count(); i++)
{
    string[] datum = Pilotak[i].SzulEv.Split(".");
    if (Convert.ToInt32(datum[0]) < 1901)
        Console.WriteLine($"\t {Pilotak[i].Nev} ({Pilotak[i].SzulEv})");
}

//6.
int legkisebbIndexe = 0;
for (int i = 1; i < Pilotak.Count(); i++)
{
    if (Pilotak[i].Rajtszam < Pilotak[legkisebbIndexe].Rajtszam && Pilotak[i].Rajtszam != -1)
        legkisebbIndexe = i;
}
Console.WriteLine($"6.Feladat: {Pilotak[legkisebbIndexe].Nemzetiseg}");


//7.
int[] elofordultSzamok = new int[Pilotak.Count()];
int elofordultIndex = 0;
Console.Write("7.Feladat: ");
for (int i = 1; i < Pilotak.Count(); i++)
{
    if (Pilotak[i].Rajtszam != -1)
    {
        if (!elofordultSzamok.Contains(Pilotak[i].Rajtszam))
        {
            elofordultSzamok[elofordultIndex] = Pilotak[i].Rajtszam;
            elofordultIndex++;
        }
        else
            Console.Write($"{Pilotak[i].Rajtszam}, ");
    }
}
sr.Close();
//vegso