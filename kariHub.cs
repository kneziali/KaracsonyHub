Console.CursorVisible = false;

string[] options = { "Karácsonyi receptek", "Karácsonyi Zenék", "Program ötletek" };

int option = 0;
int top = Console.CursorTop;
bool selected = false;


string mezeskalacs = @"
════════════ MÉZESKALÁCS ════════════

HOZZÁVALÓK:
• 50 dkg finomliszt
• 15 dkg porcukor
• 15 dkg méz
• 10 dkg vaj
• 2 tojás
• 1 teáskanál szódabikarbóna
• 2 teáskanál mézeskalács-fűszerkeverék

ELKÉSZÍTÉS:
1. A mézet és a vajat melegítsd össze.
2. Keverd össze a lisztet, porcukrot,
   szódabikarbónát és a fűszereket.
3. Add hozzá a tojásokat és a mézes vajat.
4. Gyúrd össze, majd pihentesd hűtőben 1 órát.
5. Nyújtsd ki, és szaggass formákat.
6. Süsd 180°C-on 8-10 percig.
";

string diosBejgli = @"
════════════ DIÓS BEJGLI ════════════

HOZZÁVALÓK A TÉSZTÁHOZ:
• 50 dkg finomliszt
• 20 dkg vaj
• 5 dkg porcukor
• 2 tojássárgája
• 1 dl tej
• 2 dkg élesztő
• 1 csipet só

TÖLTELÉK:
• 25 dkg darált dió
• 15 dkg cukor
• 1 dl tej
• Reszelt citromhéj
• Vaníliás cukor

ELKÉSZÍTÉS:
1. Az élesztőt futtasd fel langyos tejben.
2. Gyúrd össze a tészta hozzávalóit.
3. Pihentesd 30 percig.
4. Keverd össze a diót, cukrot, tejet és
   a citromhéjat.
5. Nyújtsd ki a tésztát, kend rá a tölteléket.
6. Tekerd fel, majd kend le tojással.
7. Szurkáld meg villával.
8. Süsd 180°C-on 30-35 percig.
";

string hokifli = @"
════════════ HÓKIFLI ════════════

HOZZÁVALÓK:
• 30 dkg finomliszt
• 20 dkg hideg vaj
• 10 dkg darált dió
• 5 dkg porcukor
• 1 csomag vaníliás cukor
• 1 csipet só

A FORGATÁSHOZ:
• 10 dkg porcukor
• 1 csomag vaníliás cukor

ELKÉSZÍTÉS:
1. Keverd össze a lisztet, diót, porcukrot
   és a sót.
2. Add hozzá a hideg vajat.
3. Gyúrd össze, majd hűtsd 30 percig.
4. Formázz apró kifliket.
5. Helyezd sütőpapíros tepsire.
6. Süsd 175°C-on 12-15 percig.
7. Még langyosan forgasd vaníliás porcukorba.
";

string zserbo = @"
════════════ ZSERBÓ ════════════

HOZZÁVALÓK A TÉSZTÁHOZ:
• 50 dkg finomliszt
• 25 dkg vaj
• 5 dkg cukor
• 1 tojás
• 1 dl tej
• 2 dkg élesztő
• 1 csipet só

TÖLTELÉK:
• 25 dkg darált dió
• 20 dkg baracklekvár
• 15 dkg cukor

CSOKOLÁDÉMÁZ:
• 15 dkg étcsokoládé
• 2 evőkanál olaj

ELKÉSZÍTÉS:
1. Futtasd fel az élesztőt langyos tejben.
2. Gyúrd össze a tészta hozzávalóit.
3. Oszd három egyenlő részre.
4. Az első lapot kend meg lekvárral,
   majd szórd meg cukros dióval.
5. Ismételd meg a második lappal.
6. Fedd be a harmadik lappal.
7. Süsd 180°C-on 25-30 percig.
8. Kihűlés után vond be csokoládéval.
9. Hagyd megszilárdulni, majd szeleteld.
";

string zene1 = @"
══════ ALL I WANT FOR CHRISTMAS IS YOU ══════
Mariah Carey – Vidám, romantikus karácsonyi popsláger.
";

string zene2 = @"
════════════ LAST CHRISTMAS ════════════
Wham! – Klasszikus, szerelmes karácsonyi sláger.
";

string zene3 = @"
════════════ JINGLE BELLS ════════════
James Lord Pierpont – Vidám, hagyományos karácsonyi dal.
";

string zene4 = @"
════════════ FELIZ NAVIDAD ════════════
José Feliciano – Vidám, spanyol-angol karácsonyi zene.
";

string zene5 = @"
════ ROCKIN' AROUND THE CHRISTMAS TREE ════
Brenda Lee – Pörgős, táncos ünnepi sláger.
";

string zene6 = @"
════════════ WHITE CHRISTMAS ════════════
Bing Crosby – Meghitt, havas karácsonyi hangulat.
";

string zene7 = @"
════════════ LET IT SNOW ════════════
Vaughn Monroe – Romantikus, klasszikus téli dal.
";

string zene8 = @"
════ IT'S BEGINNING TO LOOK A LOT LIKE CHRISTMAS ════
Michael Bublé – Elegáns, ünnepi hangulatú dal.
";


while (!selected)
{
    Console.SetCursorPosition(0, top);

    for (int i = 0; i < options.Length; i++)
    {
        if (i == option)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
        }
        else
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        Console.WriteLine($"  {options[i]}  ");
    }

    Console.ResetColor();

    switch (Console.ReadKey(true).Key)
    {
        case ConsoleKey.UpArrow:
            option = option == 0 ? options.Length - 1 : option - 1;
            break;

        case ConsoleKey.DownArrow:
            option = option == options.Length - 1 ? 0 : option + 1;
            break;

        case ConsoleKey.Enter:
            selected = true;
            break;
    }
}

Console.CursorVisible = true;
Console.WriteLine($"\nYou selected: {option}");



if (option == 0)
{
    Console.Clear();
    Console.WriteLine("(1) Mézeskalács");
    Console.WriteLine("(2) Diós Bejgli");
    Console.WriteLine("(3) Hókifli");
    Console.WriteLine("(4) Zserbó");
    Console.Write("Melyiket nézed meg: ");
    int receptekV = int.Parse(Console.ReadLine());


    while (receptekV != 0 && receptekV != 1 && receptekV != 2 && receptekV != 3 && receptekV != 4)
    {
        Console.WriteLine("Retard geci");
        Console.Write("Melyiket nézed meg: ");
        receptekV = int.Parse(Console.ReadLine());
    }

    if (receptekV == 1)
    {
        Console.Clear();
        Console.WriteLine(mezeskalacs);
        Console.Write("(1) Elviszem a receptet (2) Vissza: ");
        int receptekM = int.Parse(Console.ReadLine());

    }

    if (receptekV == 2)
    {
        Console.Clear();
        Console.WriteLine(diosBejgli);
        Console.Write("(1) Elviszem a receptet (2) Vissza: ");
        int receptekM = int.Parse(Console.ReadLine());

    }

    if (receptekV == 3)
    {
        Console.Clear();
        Console.WriteLine(hokifli);
        Console.Write("(1) Elviszem a receptet (2) Vissza: ");
        int receptekM = int.Parse(Console.ReadLine());

    }

    if (receptekV == 4)
    {
        Console.Clear();
        Console.WriteLine(zserbo);
        Console.Write("(1) Elviszem a receptet (2) Vissza: ");
        int receptekM = int.Parse(Console.ReadLine());


        //if (receptekM == 1)
        //{

        //}
        //if (receptekM == 2)
        //{
            
        //}
    }

}

if (option == 1)
{
    Console.Clear() ;

    Console.WriteLine(zene1);
    Console.WriteLine(zene2);
    Console.WriteLine(zene3);
    Console.WriteLine(zene4);
    Console.WriteLine(zene5);
    Console.WriteLine(zene6);
    Console.WriteLine(zene7);
    Console.WriteLine(zene8);
    Console.Write("(1-8) Elviszem a receptet (9) Vissza: ");
    int zeneL = int.Parse(Console.ReadLine());

    //if (zeneL == 1)
    //{

    //}


    //if (zeneL == 2)
    //{

    //}

    //if (zeneL == 3)
    //{

    //}

    //if (zeneL == 4)
    //{

    //}

    //if (zeneL == 5)
    //{

    //}

    //if (zeneL == 6)
    //{

    //}

    //if (zeneL == 7)
    //{

    //}

    //if (zeneL == 8)
    //{

    //}

    //if (zeneL == 9)
    //{

    //}

}

Console.ReadKey();
