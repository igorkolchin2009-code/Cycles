string kasutajaNimi = "";
do
{
    Console.WriteLine("Palun sisesta oma kasutajanimi: ");
    kasutajaNimi = Console.ReadLine();
} while (kasutajaNimi != "user1");
if (kasutajaNimi == "user1")
{
    int ruuduSuurus = 0;

    do
    {
        Console.WriteLine("Kui suurt ruutu saada tahab?");
        ruuduSuurus = int.Parse(Console.ReadLine());
    } while (ruuduSuurus < 0 || ruuduSuurus > 20);

    char reaKujund = '▒';
    string üksRida = "";
    int tsükliMuutuja = ruuduSuurus;

    do
    {
        üksRida = üksRida + "_" + reaKujund;
        tsükliMuutuja = tsükliMuutuja - 1;
    } while (tsükliMuutuja != 0);

    tsükliMuutuja = ruuduSuurus;

    do
    {
        Console.WriteLine(üksRida);
        tsükliMuutuja -= 1;
    } while (tsükliMuutuja != 0);

    Console.WriteLine($"Palun, siin on sinu ruut, suurega {ruuduSuurus}x{ruuduSuurus}");

}