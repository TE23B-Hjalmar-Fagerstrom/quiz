int rätt = 0;

Console.WriteLine("Vad heter du?");
string name = Console.ReadLine();

Console.WriteLine($"Hej {name} och välkomen till min fråge sport.");
Console.WriteLine("Din första fråga är 'Hur länge lyser solen?'");
Console.WriteLine("A: 13 timmar   B: fyra och en halv miljarder år  C: sex miljarder år  D: 16 timmar");

string fråga_ett = Console.ReadLine();

if (fråga_ett.ToLower() == "b")
{
    RATT();
    rätt++;
}else
{
    FEL();
}

Console.WriteLine("Den andra fråga är 'Kan du läsa?'");
Console.WriteLine("A: ja   B: nej  C: jag kan skriva  D: har inget med dig att göra");


string fråga_två = Console.ReadLine();

if (fråga_två.ToLower() == "a")
{
    RATT();
    rätt++;
}else
{
    FEL();
}

Console.WriteLine("Den tredje frågan är ''");

string fråga_tre = Console.ReadLine();

if (fråga_tre.ToLower() == "c")
{
    RATT();
    rätt++;
}else
{
    FEL();
}

Console.WriteLine("Den sista frågan är ''");

string fråga_fyra = Console.ReadLine();

if (fråga_fyra.ToLower() == "c")
{
    RATT();
    rätt++;
}else
{
    FEL();
}

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




static void FEL()
{
    Console.WriteLine(""" 
 .----------------.  .----------------.  .----------------. 
| .--------------. || .--------------. || .--------------. |
| |  _________   | || |  _________   | || |   _____      | |
| | |_   ___  |  | || | |_   ___  |  | || |  |_   _|     | |
| |   | |_  \_|  | || |   | |_  \_|  | || |    | |       | |
| |   |  _|      | || |   |  _|  _   | || |    | |   _   | |
| |  _| |_       | || |  _| |___/ |  | || |   _| |__/ |  | |
| | |_____|      | || | |_________|  | || |  |________|  | |
| |              | || |              | || |              | |
| '--------------' || '--------------' || '--------------' |
 '----------------'  '----------------'  '----------------' 
""");
}

static void RATT()
{
    Console.WriteLine("""
 .----------------.  .----------------.  .----------------.  .----------------. 
| .--------------. || .--------------. || .--------------. || .--------------. |
| |  _______     | || |   O  __  O   | || |  _________   | || |  _________   | |
| | |_   __ \    | || |     /  \     | || | |  _   _  |  | || | |  _   _  |  | |
| |   | |__) |   | || |    / /\ \    | || | |_/ | | \_|  | || | |_/ | | \_|  | |
| |   |  __ /    | || |   / ____ \   | || |     | |      | || |     | |      | |
| |  _| |  \ \_  | || | _/ /    \ \_ | || |    _| |_     | || |    _| |_     | |
| | |____| |___| | || ||____|  |____|| || |   |_____|    | || |   |_____|    | |
| |              | || |              | || |              | || |              | |
| '--------------' || '--------------' || '--------------' || '--------------' |
 '----------------'  '----------------'  '----------------'  '----------------' 
""");
}