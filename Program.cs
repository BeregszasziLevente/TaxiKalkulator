
Console.Write("Az utas neve: ");
string nev=Console.ReadLine();

Console.Write("Megtett távolság km-ben: ");
int tav = int.Parse(Console.ReadLine());

Console.Write("Éjszakai utazás? (igen/nem) ");
string estiInput=Console.ReadLine();
bool esti = false;
if (estiInput=="igen") esti= true;

Console.Write("Alapdíj: ");
int alapdij=int.Parse(Console.ReadLine());

Console.Write("Kilóméterdíj: ");
int kmdij=int.Parse(Console.ReadLine());

Console.Write("Éjszakai pótlék szorzója: ");
double potlek = Convert.ToDouble(Console.ReadLine());

int alaposszeg = alapdij + (tav * kmdij);
double vegosszeg = 0.0;
string status = "Nem volt éjszakai pótlék felszámolva.";

if (esti) { 
    vegosszeg = alaposszeg * potlek;
    status = "20% éjszakai pótlék felszámolva.";
}
else vegosszeg = alaposszeg;

Console.WriteLine("--------------------------------------");

Console.WriteLine($"Utas neve: {nev}");
Console.WriteLine($"Megtett távolság: {tav} km");
Console.WriteLine($"Alapérték: {alapdij} Ft");
Console.WriteLine($"Fizetendő végösszeg: {vegosszeg:f0}");
Console.WriteLine($"Státusz: {status}");

Console.WriteLine("--------------------------------------");
