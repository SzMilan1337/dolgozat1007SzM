using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace dolgozat1007SzM
{
    internal class versenyzo
    {
        public string nev { get; set; }
        public int szul_ev { get; set; }
        public int rajtszam { get; set; }
        public bool nem { get; set; }

        public string kategoria { get; set; }

        public Dictionary<string, TimeSpan> idok = new Dictionary<string, TimeSpan>();

        public versenyzo(string sor)
        {
            var v = sor.Split(";");
            nev = v[0];
            szul_ev = Convert.ToInt32(v[1]);
            rajtszam = Convert.ToInt32(v[2]);
            nem = v[3] == "n";
            kategoria = v[4];
            idok.Add("uszas", TimeSpan.Parse(v[5]));
            idok.Add("elsodepo", TimeSpan.Parse(v[6]));
            idok.Add("kerekpar", TimeSpan.Parse(v[7]));
            idok.Add("masodikdepo", TimeSpan.Parse(v[8]));
            idok.Add("futas", TimeSpan.Parse(v[9]));

        }

        public override string ToString()
        {
            return $"Versenyző neve: {nev}" +
                $"\tNeme: {(nem ? "Nő" : "Férfi")}" +
                $"\tRajtszáma: {rajtszam}," +
                $"\tSzületési éve: {szul_ev} " +
                $"\nIdejei: " +
                $"\n\tÚszás: {idok["uszas"]} " +
                $"\n\tElső depo: {idok["elsodepo"]}" +
                $"\n\tKerékpár: {idok["kerekpar"]}" +
                $"\n\tMásodik depo: {idok["masodikdepo"]}" +
                $"\n\tFutás: {idok["futas"]}";
        }
    }
}
