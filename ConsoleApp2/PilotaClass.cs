using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilotakClass
{
    internal class Pilota
    {
        string nev;
        string szulEv;
        string nemzetiseg;
        int rajtszam;

        public Pilota(string nev, string szulEv, string nemzetiseg, int rajtszam)
        {
            this.nev = nev;
            this.szulEv = szulEv;
            this.nemzetiseg = nemzetiseg;
            this.rajtszam = rajtszam;
        }

        public string Nev { get => nev; set => nev = value; }
        public string SzulEv { get => szulEv; set => szulEv = value; }
        public string Nemzetiseg { get => nemzetiseg; set => nemzetiseg = value; }
        public int Rajtszam { get => rajtszam; set => rajtszam = value; }
    }
}
