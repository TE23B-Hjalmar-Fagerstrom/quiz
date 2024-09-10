Console.WriteLine("Vad heter du?");
string name = Console.ReadLine();

Console.WriteLine($"Hej {name} och välkomen till min fråge sport.");
Console.WriteLine("");


int rätt = 0;

if (rätt == 4)
{
    Console.WriteLine($"Bra jobbat {name}! Du fick alla rätt!");
}

if (rätt == 2 )
{
    Console.WriteLine($"Bra försök {name}. Du fick {rätt} frågor rätt.");
}

if (rätt == 0 )
{
    Console.WriteLine($"Bättre lyka nästa gång {name}. Du fick {rätt} frågor rätt.");
}

Console.ReadLine();