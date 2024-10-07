using dolgozat1007SzM;
using System.Text;


List<versenyzo> versenyzok = [];
using StreamReader sr = new(
    path: @"..\..\..\src\forras.txt",
    encoding: Encoding.UTF8);
_ = sr.ReadLine();
while (!sr.EndOfStream) versenyzok.Add(new(sr.ReadLine()));

Console.WriteLine($"4. Feladat: {versenyzok.Count} versenyző fejezte be a versenyt. ");
int korkateg = versenyzok.Count(p => p.kategoria == "elit");
Console.WriteLine($"5. Feladat: {korkateg} db versenyző van a(z) '25-29' kategóriában.");
var atlageletkor = versenyzok.Where(v => v.nem);
double atlelet = (atlageletkor.Count()*DateTime.Now.Year - atlageletkor.Sum( v => v.szul_ev )) / (double)atlageletkor.Count();
Console.WriteLine($"6. Feladat: Az átlag életkora a versenyzőknek: {atlelet}.");
double uszashsz = Math.Round(versenyzok.Sum(v => v.idok["uszas"].TotalHours), 2);
Console.WriteLine($"7. Feladat: A versenyzők úszással töltött ideje, órákban: {uszashsz}.");