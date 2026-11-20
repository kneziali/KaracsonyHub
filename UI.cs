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

    Console.SetCursorPosition(0, 25);
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
        Console.Clear();
        header();
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("(1) Mézeskalács");
        Console.WriteLine("(2) Diós Bejgli");
        Console.WriteLine("(3) Hókifli");
        Console.WriteLine("(4) Zserbó");
        Console.Write("Melyiket nézed meg: ");
        border(95, 13);

        
        int receptekV = int.Parse(Console.ReadLine());
    }
    if (option == 3)
    {
        Environment.Exit(0);
    }

    Console.ReadKey();
    selected = false;
}

