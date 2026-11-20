Console.Title = "KarácsonyHUB";
Console.CursorVisible = false;
//int kivalasztott = 1;

while (true)
{
    Console.Clear();

    // 1. FELSŐ PIROS-FEHÉR SÁV (pont 96 karakter széles)
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
            Console.ForegroundColor = ConsoleColor.White; // Megfordítva sakktábla / cukorpálca hatás!
            Console.Write("██");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("██");
        }
    }
    Console.WriteLine();

    // 2. ZÖLD KARÁCSONYI FELIRAT
    Console.ForegroundColor = ConsoleColor.White;
    string banner = @"  
,--. ,--.                                                            ,--.  ,--.,--. ,--.,-----.  
|  .'   / ,--,--.,--.--. ,--,--. ,---. ,---.  ,---. ,--,--, ,--. ,--.|  '--'  ||  | |  ||  |) /_ 
|  .   ' ' ,-.  ||  .--'' ,-.  || .--'(  .-' | .-. ||      \ \  '  / |  .--.  ||  | |  ||  .-.  \
|  |\   \\ '-'  ||  |   \ '-'  |\ `--..-'  `)' '-' '|  ||  |  \   '  |  |  |  |'  '-'  '|  '--' /
`--' '--' `--`--'`--'    `--`--' `---'`----'  `---' `--''--'.-'  /   `--'  `--' `-----' `------' 
                                                            `---'                                ";
    Console.WriteLine(banner);

    // 3. ALSÓ PIROS-FEHÉR SÁV
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
    Console.WriteLine();

    // 4. TELJES KERET KIRAJZOLÁSA (teteje, oldala, alja egyszerre)
    Console.ForegroundColor = ConsoleColor.Red;
    for (int i = 0; i < 96; i++)
    {
        if (i == 0)
        {
            Console.Write("╔");
        }
        else if (i == 95)
        {
            Console.Write("╗");
            break;
        }
        else
        {
            Console.Write("═");
        }
    }

    for (int i = 0; i < 13; i++)
    {
        Console.SetCursorPosition(0, 13 + i);
        Console.Write("║");
        Console.SetCursorPosition(95, 13 + i);
        Console.Write("║");
    }

    Console.SetCursorPosition(0, 25);
    for (int i = 0; i < 96; i++)
    {
        if (i == 0)
        {
            Console.Write("╚");
        }
        else if (i == 95)
        {
            Console.Write("╝");
        }
        else
        {
            Console.Write("═");
        }
    }

    // 5. BELSŐ ELVÁLASZTÓ VONAL A DOBOZON BELÜL
    Console.SetCursorPosition(0, 16);
    for (int i = 0; i < 96; i++)
    {
        if (i == 0)
        {
            Console.Write("║");
        }
        else if (i == 95)
        {
            Console.Write("║");
        }
        else
        {
            Console.Write("─");
        }
    }

    // 6. MENÜSZÖVEGEK BEÍRÁSA A KERETEN BELÜLRE
    Console.SetCursorPosition(20, 14);
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write("* * *   V Á L A S S Z   A Z   O P C I Ó K   K Ö Z Ü L   * * *");


        // 1. opció kirajzolása
    Console.SetCursorPosition(35, 19);
    Console.WriteLine("Első opció    ");
    Console.SetCursorPosition(35, 20);

    Console.WriteLine("Első opció    ");
    Console.SetCursorPosition(35, 21);

    Console.WriteLine("Első opció    ");
    Console.SetCursorPosition(35, 22);

    Console.ReadLine();
        

    // 7. MI TÖRTÉNJEN ENTER UTÁN?
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.White;



    // int inputX = Console.CursorLeft;
    //int inputY = Console.CursorTop;

    // Visszaugrunk a beíró mezőbe
    //Console.SetCursorPosition(inputX, inputY);
    //string valasz = Console.ReadLine();

    //if (valasz == "0")
    //{
    //   break;
    //}
}

