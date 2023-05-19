using PilotakClass;
using System.IO;

StreamReader sr = new StreamReader("pilotak.csv");
List<Pilota> Pilotak = new List<Pilota>();
sr.ReadLine();
while (!sr.EndOfStream)
{
    string[] adatok = sr.ReadLine().Split(";");
    Pilota sor = new Pilota(adatok[0], adatok[1], adatok[2], Convert.ToInt32(adatok[3]));
    Pilotak.Add(sor);
}