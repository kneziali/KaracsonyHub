Console.Title = "KarácsonyHUB";
Console.CursorVisible = false;
string[] options = { "Karácsonyi receptek", "Karácsonyi Zenék", "Program ötletek", "Kilépés" };


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
══════ (1) ALL I WANT FOR CHRISTMAS IS YOU ══════
Mariah Carey – Vidám, romantikus karácsonyi popsláger.
";

string zene2 = @"
════════════ (2) LAST CHRISTMAS ════════════
Wham! – Klasszikus, szerelmes karácsonyi sláger.
";

string zene3 = @"
════════════ (3) JINGLE BELLS ════════════
James Lord Pierpont – Vidám, hagyományos karácsonyi dal.
";

string zene4 = @"
════════════ (4) FELIZ NAVIDAD ════════════
José Feliciano – Vidám, spanyol-angol karácsonyi zene.
";

string zene5 = @"
════ ROCKIN' (5) AROUND THE CHRISTMAS TREE ════
Brenda Lee – Pörgős, táncos ünnepi sláger.
";

string zene6 = @"
════════════ (6) WHITE CHRISTMAS ════════════
Bing Crosby – Meghitt, havas karácsonyi hangulat.
";

string zene7 = @"
════════════ (7) LET IT SNOW ════════════
Vaughn Monroe – Romantikus, klasszikus téli dal.
";

string zene8 = @"
════ (8) IT'S  BEGINNING TO LOOK A LOT LIKE CHRISTMAS ════
Michael Bublé – Elegáns, ünnepi hangulatú dal.
";


string program1 = @"
══════════ (1) KARÁCSONYI KINCSESKERESÉS ══════════
Elrejtett ajándékok és ünnepi rejtvények felkutatása.
";

string program2 = @"
══════════ (2) KARÁCSONYI SZABADULÓSZOBA ══════════
Ünnepi fejtörők megoldása a karácsonyi küldetés teljesítéséhez.
";

string program3 = @"
══════════ (3) FORRÓCSOKI-KÓSTOLÓ ══════════
Különleges forró csokoládék kipróbálása különböző ízekben.
";

string program4 = @"
══════════ (4) KARÁCSONYI FOTÓZÁS ══════════
Vicces és kreatív ünnepi képek készítése jelmezekben.
";

string program5 = @"
══════════ (5) MÉZESKALÁCS-FALU ÉPÍTÉS ══════════
Egy egész apró karácsonyi falu elkészítése mézeskalácsból.
";

string program6 = @"
══════════ (6) KARÁCSONYI KARAOKE ══════════
Kedvenc karácsonyi dalok közös eléneklése.
";

string program7 = @"
══════════ (7) KARÁCSONYI FILMEST ══════════
Filmvetítés takarókkal, pattogatott kukoricával és finomságokkal.
";

string program8 = @"
══════════ (8) ADVENTI ÉJSZAKAI SÉTA ══════════
A város ünnepi fényeinek felfedezése esti séta közben.
";



int option = 0;
int top = Console.CursorTop;
bool selected = false;

void header()
{
    for (int i = 0; i < 48; i++)
    {
        if (i % 2 == 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("██");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("██");
        }
    }
    Console.WriteLine();

    for (int i = 0; i < 48; i++)
    {
        if (i % 2 == 0)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("██");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("██");
        }
    }
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.White;
    string banner = @"  
,--. ,--.                                                            ,--.  ,--.,--. ,--.,-----.  
|  .'   / ,--,--.,--.--. ,--,--. ,---. ,---.  ,---. ,--,--, ,--. ,--.|  '--'  ||  | |  ||  |) /_ 
|  .   ' ' ,-.  ||  .--'' ,-.  || .--'(  .-' | .-. ||      \ \  '  / |  .--.  ||  | |  ||  .-.  \
|  |\   \\ '-'  ||  |   \ '-'  |\ `--..-'  `)' '-' '|  ||  |  \   '  |  |  |  |'  '-'  '|  '--' /
`--' '--' `--`--'`--'    `--`--' `---'`----'  `---' `--''--'.-'  /   `--'  `--' `-----' `------' 
                                                            `---'                                ";
    Console.WriteLine(banner);

    for (int i = 0; i < 48; i++)
    {
        if (i % 2 == 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("██");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("██");
        }
    }
    Console.WriteLine();

    for (int i = 0; i < 48; i++)
    {
        if (i % 2 == 0)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("██");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("██");
        }
    }
}

void border(int x, int y)
{
    Console.ForegroundColor = ConsoleColor.Red;
    for (int i = 0; i <= x; i++)
    {
        if (i == 0)
        {
            Console.Write("╔");
        }
        else if (i == x)
        {
            Console.Write("╗");
            break;
        }
        else
        {
            Console.Write("═");
        }
    }

    for (int i = 0; i < y; i++)
    {
        Console.SetCursorPosition(0, y + i);
        Console.Write("║");
        Console.SetCursorPosition(x, y + i);
        Console.Write("║");
    }

    Console.SetCursorPosition(0, y + 12);
    for (int i = 0; i <= x; i++)
    {
        if (i == 0)
        {
            Console.Write("╚");
        }
        else if (i == x)
        {
            Console.Write("╝");
        }
        else
        {
            Console.Write("═");
        }
    }

    Console.SetCursorPosition(0, 16);
    for (int i = 0; i <= x; i++)
    {
        if (i == 0)
        {
            Console.Write("║");
        }
        else if (i == x)
        {
            Console.Write("║");
        }
        else
        {
            Console.Write("─");
        }
    }
}



// AZ APP KEZDEZETE



while (true)
{
    Console.Clear();

    header();
    Console.WriteLine();
    Console.WriteLine();
    border(95, 13);

    Console.SetCursorPosition(20, 14);

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write("* * *   V Á L A S S Z   A Z   O P C I Ó K   K Ö Z Ü L   * * *");

    // VÁLSZTÓ MENÜ

    while (!selected)
    {
        Console.SetCursorPosition(0, top);

        for (int i = 0; i < options.Length; i++)
        {
            if (i == option)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Yellow;
            }

            Console.SetCursorPosition(35, 19 + i);

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

    Console.Clear();
    Console.ForegroundColor = ConsoleColor.White;
    Console.CursorVisible = false;

    if (option == 0)
    {
        Console.CursorVisible = true;
        Console.Clear();
        header();
        Console.WriteLine();
        Console.WriteLine();
        border(95, 13);
        Console.SetCursorPosition(20, 14);

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("* * *   V Á L A S S Z   A Z   O P C I Ó K   K Ö Z Ü L   * * *");
        Console.WriteLine();

        Console.SetCursorPosition(35, 18);
        Console.WriteLine("(1) Mézeskalács");
        Console.SetCursorPosition(35, 19);
        Console.WriteLine("(2) Diós Bejgli");
        Console.SetCursorPosition(35, 20);
        Console.WriteLine("(3) Hókifli");
        Console.SetCursorPosition(35, 21);
        Console.WriteLine("(4) Zserbó");
        Console.SetCursorPosition(35, 22);
        Console.WriteLine("(5) Vissza");
        Console.SetCursorPosition(35, 23);


        Console.Write("Melyiket nézed meg: ");

        
        try
        {
            int receptekV = int.Parse(Console.ReadLine());
            if (receptekV == 5) { }

            if (receptekV == 1)
            {
                Console.Clear();
                header();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine(mezeskalacs);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("(1) Elviszem a receptet (2) Vissza: ");
                try
                {
                    int receptekM = int.Parse(Console.ReadLine());
                    //if (receptekM == 1)
                    //{

                    //}
                    if (receptekM == 2) { }
                }
                catch(SystemException)
                {
                    continue;
                }
                

            }

            if (receptekV == 2)
            {
                Console.Clear();
                header();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine(diosBejgli);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("(1) Elviszem a receptet (2) Vissza: ");
                try
                {
                    int receptekM = int.Parse(Console.ReadLine());
                    //if (receptekM == 1)
                    //{

                    //}
                    if (receptekM == 2) { }
                }
                catch (SystemException)
                {
                    continue;
                }

            }

            if (receptekV == 3)
            {
                Console.Clear();
                header();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine(hokifli);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("(1) Elviszem a receptet (2) Vissza: ");
                try
                {
                    int receptekM = int.Parse(Console.ReadLine());
                    //if (receptekM == 1)
                    //{

                    //}
                    if (receptekM == 2) { }
                }
                catch (SystemException)
                {
                    continue;
                }

            }

            if (receptekV == 4)
            {
                Console.Clear();
                header();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine(zserbo);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("(1) Elviszem a receptet (2) Vissza: ");
                try
                {
                    int receptekM = int.Parse(Console.ReadLine());
                    //if (receptekM == 1)
                    //{

                    //}
                    if (receptekM == 2){}
                }
                catch (SystemException)
                {
                    continue;
                }
            }

        }
        catch (SystemException)
        {

            continue;
        }
        
    }

    Console.CursorVisible = false;

    if (option == 1)
    {
        Console.CursorVisible = true;
        Console.Clear();

        header();
        Console.WriteLine();

        Console.ForegroundColor = ConsoleColor.White;

        Console.WriteLine(zene1);
        Console.WriteLine(zene2);
        Console.WriteLine(zene3);
        Console.WriteLine(zene4);
        Console.WriteLine(zene5);
        Console.WriteLine(zene6);
        Console.WriteLine(zene7);
        Console.WriteLine(zene8);
        Console.ForegroundColor = ConsoleColor.Green;

        Console.Write("(1-8) Elviszem a receptet (9) Vissza: ");

        try
        {
            int zeneL = int.Parse(Console.ReadLine());

            if (zeneL == 9) { }
        }
        catch(SystemException)
        {
            continue;
        }

        

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
    Console.CursorVisible = false;


    if (option == 2)
    {
        Console.CursorVisible = true;
        Console.Clear();

        header();
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine(program1);
        Console.WriteLine(program2);
        Console.WriteLine(program3);
        Console.WriteLine(program4);
        Console.WriteLine(program5);
        Console.WriteLine(program6);
        Console.WriteLine(program7);
        Console.WriteLine(program8);
        Console.ForegroundColor = ConsoleColor.Green;

        Console.Write("(1-8) Ellopom az ötletet (9) Vissza: ");
        

        try
        {
            int programL = int.Parse(Console.ReadLine());

            if (programL == 9) { }
        }
        catch (SystemException)
        {
            continue;
        }


        //if (programL == 1)
        //{

        //}

        //if (programL == 2)
        //{

        //}

        //if (programL == 3)
        //{

        //}

        //if (programL == 4)
        //{

        //}

        //if (programL == 5)
        //{

        //}

        //if (programL == 6)
        //{

        //}

        //if (programL == 7)
        //{

        //}

        //if (programL == 8)
        //{

        //}

        //if (programL == 9)
        //{

        //}


    }
    Console.CursorVisible = false;



    if (option == 3)
    {
        Environment.Exit(0);
    }

    Console.ReadKey();
    selected = false;
}