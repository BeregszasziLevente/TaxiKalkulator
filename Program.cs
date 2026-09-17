
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

double potlek = 1.0;
if (esti) potlek = 1.2;

int alaposszeg = alapdij + (kmdij * kmdij);

