Console.WriteLine("Tere kasutaja palun siseta oma eesnimi");
string nimi = "";
do
{
    Console.WriteLine("Sisu nimi on:");
    nimi = Console.ReadLine();
} while (nimi == "");

int sünnikuupäev = 0;
Console.WriteLine("Sisesta oma sünnikuupäev päev");
while (sünnikuupäev > 31 || sünnikuupäev < 1)
{
    Console.WriteLine("Palun sisesta õige kuupäev vahemikus 1-31");
    sünnikuupäev = int.Parse(Console.ReadLine());
}

Console.WriteLine("Sisesra ka oma sünnikuu");
string sünnikuu = "";
while (sünnikuu == "")
{
    Console.WriteLine("Siseta õige kuu:");
    sünnikuu = Console.ReadLine();
    switch (sünnikuu)
    {
        case "detsember":
            Console.WriteLine("Oled sisetanud 12.nda kuu - detsembri");
            break;
        default:
            Console.WriteLine("Ei tunne sellist sünnikuud");
            sünnikuu = "";
            break;
    }
}