for (int i = 0; i <= 48; i++)
{
    if (i % 2 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("█");
        Console.Write("█");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("█");
        Console.Write("█");
    }
}
Console.WriteLine("");
for (int i = 0; i <= 48; i++)
{
    if (i % 2 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("█");
        Console.Write("█");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("█");
        Console.Write("█");
    }
}
Console.ForegroundColor = ConsoleColor.White;
string banner = @"                                                                                               
,--. ,--.                                                            ,--.  ,--.,--. ,--.,-----.   
|  .'   / ,--,--.,--.--. ,--,--. ,---. ,---.  ,---. ,--,--, ,--. ,--.|  '--'  ||  | |  ||  |) /_  
|  .   ' ' ,-.  ||  .--'' ,-.  || .--'(  .-' | .-. ||      \ \  '  / |  .--.  ||  | |  ||  .-.  \ 
|  |\   \\ '-'  ||  |   \ '-'  |\ `--..-'  `)' '-' '|  ||  |  \   '  |  |  |  |'  '-'  '|  '--' / 
`--' '--' `--`--'`--'    `--`--' `---'`----'  `---' `--''--'.-'  /   `--'  `--' `-----' `------'  
                                                            `---'                                 ";

Console.WriteLine("");
Console.WriteLine(banner);

for (int i = 0; i <= 48; i++)
{
    if (i % 2 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("█");
        Console.Write("█");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("█");
        Console.Write("█");
    }
}
Console.WriteLine("");
for (int i = 0; i <= 48; i++)
{
    if (i % 2 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("█");
        Console.Write("█");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("█");
        Console.Write("█");
    }
}

Console.WriteLine("");

for (int i = 0; i <=96; i++)
{
    Console.ForegroundColor = ConsoleColor.White;
    if (i == 0)
    {
        Console.Write("╔");
    }
    if (i == 96)
    {
        Console.Write("╗");
        break;
    }
    Console.Write("═");
}

Console.WriteLine("");
Console.WriteLine(" H e l l o   w o r l d");
Console.WriteLine(" H e l l o   w o r l d");
Console.WriteLine(" H e l l o   w o r l d");
Console.WriteLine(" H e l l o   w o r l d");

for (int i = 0; i <= 10; i++)
{
    Console.SetCursorPosition(0, i+12);
    Console.Write("║");
}

for (int i = 0; i <= 10; i++)
{
    Console.SetCursorPosition(97, i + 12);
    Console.Write("║");
}

Console.WriteLine("");


for (int i = 0; i <= 96; i++)
{
    Console.ForegroundColor = ConsoleColor.White;
    if (i == 0)
    {
        Console.Write("╚");
    }
    if (i == 96)
    {
        Console.Write("╝");
        break;
    }
    Console.Write("═");
}

