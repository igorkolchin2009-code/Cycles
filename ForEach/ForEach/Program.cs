string[] konsoolid = { "PLESIŠTEIŠON 1", "nintendo witch", "valve steam machine" };

//List<string> mängud = new List<string>();

//foreach (var konsool in konsoolid)
//{
//    Console.WriteLine(konsool);
//}

//for (int i = 0; i < konsoolid.Length; i++)
//{
//    Console.Write(konsoolid[i]);
//}

//string currentEnty = ""; //ajutine muutuja mis hoiab tekstiüüpi andmeid, hetkel tühi

//while (currentEnty ==  "") //whole tsükkel mis toiib niikaua kuni currentetry on tühi
//{
//    Console.WriteLine("Sisesta mäng või \"ei taha\" kui sooovid esitust lõpetada");
//    //esitahe kasutajale sõnumi
//    currentEnty = Console.ReadLine();
//    //paneme ajutisse info kasutajalt
//    if (currentEnty == "ei taha") //kui kasutaja kirjtas "ei taha", teeme ifi sisu
//    {
//        break; //break katkestab kogu tsükli, peatades sisetamise
//    }
//    //mängud[i] = currentEnty;
//    mängud.Add(currentEnty); //lisame loedile otsa kasutaja sisetatud info
//    currentEnty = ""; //omistame muutujasse currententry uuesti tühja sisestuse, et tsükkel jätkus.
//}

//Console.WriteLine("\n\n\n");

//foreach (var mäng in mängud)
//{
//    Console.WriteLine(mäng);
//}
Console.WriteLine("Mis on su lemmikvärvid? Sisesta palun ühkhaaval\nKui rehkem värve ei ole, kirjuta \"rohkem ple\"");
List<string> kasutajaVärvid = new List<string>();

string sisestus = "";
do
{
    Console.WriteLine("Sisesta 1värv korraga:");
    sisestus = Console.ReadLine();
    if (sisestus != "rohkem pole")
    {
        kasutajaVärvid.Add(sisestus);
    }

} while (sisestus != "rohkem pole");

foreach (var värv in kasutajaVärvid)
{
    switch (värv)
    {
        // punane, oranz, kolane, rohaline, helesinine, temuroheline, tumesinine, lilla,
        // roosa, pruun, must, valge, hall, värvi-ei-tunta
        // roosa & oranz - neid ei ole, tagasta sõnum mis on värevispetsiifiline
        case "punane":
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-*-*- p u n a n e -*-*-");
            break;
        /* LISAGE ISESEIVALT KÕIKIDE MUUDE VÄRVI CASED */
        case "oranz":
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Oranz pole saadaval");
            break;
        case "kolane":
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-*-*- k o l a n e -*-*-");
            break;
        case "rohaline":
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-*-*- r o h a l i n e -*-*-");
            break;
        case "helesinine":
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-*-*- h e l e s i n i n e -*-*-");
            break;
        case "temuroheline":
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-*-*- t e m u t o h a l i n e -*-*-");
            break;
        case "tumesinine":
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-*-*- t u m e s i n i n e -*-*-");
            break;
        case "lilla":
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-*-*-  l i l l a -*-*-");
            break;
        case "rossa":
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Rossa pole saadaval");
            break;
        case "pruun":
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-*-*-  p r u u n -*-*-");
            break;
        case "must":
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-*-*-  m u s t -*-*-");
            break;
        case "valge":
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("-*-*-  v a l g e -*-*-");
            break;
        case "hall":
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-*-*-  h a l l -*-*-");
            break;
        default:
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Ei tunne sellist värvi{värv}");
            break;
    }
}




////5 värvituvastus
//Console.WriteLine("Milline värv sille kõige rohkem meeldib");
//string favouriteColur = Console.ReadLine();
//if (favouriteColur == "panane") 
//{
//    Console.BackgroundColor = ConsoleColor.Red;
//}
//if (favouriteColur == "oranz") 
//{
//    Console.WriteLine("Kahjuks oranzo ei ole");
//}
//if (favouriteColur == "kollane") 
//{
//    Console.BackgroundColor = ConsoleColor.Yellow;
//}
//if (favouriteColur == "rohaline") 
//{
//    Console.BackgroundColor = ConsoleColor.Green;
//}
//else
//{
//    Console.WriteLine("Värvi ei tunne");
//}
//Console.WriteLine("Värv muudetud!");