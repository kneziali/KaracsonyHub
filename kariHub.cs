Console.CursorVisible = false;

string[] options = { "Karácsonyi receptek", "Karácsonyi Zenék", "Program ötletek" };

int option = 0;
int top = Console.CursorTop;
bool selected = false;

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
    string bejgli = @"
Rövid bejgli recept

Hozzávalók (2 rúdhoz):

30 dkg liszt

15 dkg vaj

5 dkg porcukor

1 tojássárgája

1 dl tejföl

1 csipet só

1/2 csomag sütőpor

Töltelék:

20 dkg darált dió vagy mák

10 dkg cukor

1 dl tej

Reszelt citromhéj

Elkészítés:

A lisztet, vajat, porcukrot, tojássárgáját, tejfölt, sót és sütőport összegyúrjuk.

A tésztát két részre osztjuk, és vékonyra nyújtjuk.

A töltelékhez a tejet felforraljuk a cukorral, majd hozzákeverjük a diót vagy mákot.

A kihűlt tölteléket a tésztára kenjük, feltekerjük.

Megkenjük tojással, villával megszurkáljuk.

180 °C-on kb. 25–30 perc alatt aranybarnára sütjük.";


    Console.Write(bejgli);
}




Console.ReadKey();
