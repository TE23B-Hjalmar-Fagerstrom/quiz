int rätt = 0;

Console.WriteLine("Vad heter du?");
string name = Console.ReadLine();

Console.WriteLine($"Hej {name} och välkomen till min fråge sport.");
Console.WriteLine("Din första fråga är 'Kan du läsa?'");
Console.WriteLine("A: ja   B: nej  C: jag kan skriva  D: har inget med dig att göra");

string fråga_ett = Console.ReadLine();

if (fråga_ett.ToLower() == "a")
{
    RATT();
    rätt++;
}else
{
    FEL();
}

Console.WriteLine("Den andra fråga är 'Hur länge lyser solen?'");
Console.WriteLine(" A: 13 timmar   B: sex miljarder år   C: fyra och en halv miljarder år   D: 16 timmar");


string fråga_två = Console.ReadLine();

if (fråga_två.ToLower() == "c")
{
    RATT();
    rätt++;
}else
{
    FEL();
}

Console.WriteLine("Den tredje frågan är 'hur långt bort är månen'");
Console.WriteLine(" A: 246000km   B: 385000 km   C: 500km   D: 419000km ");


string fråga_tre = Console.ReadLine();

if (fråga_tre.ToLower() == "b")
{
    RATT();
    rätt++;
}else
{
    FEL();
}

Console.WriteLine("Den sista frågan är 'hur stor är jordens radie'");
Console.WriteLine(" A:4826 km    B:5619 km    C:6371 km    D:7296 km ");


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

if (rätt == 2 || rätt == 3 )
{
    Console.WriteLine($"Bra försök {name}. Du fick {rätt} frågor rätt.");
}

if (rätt == 0)
{
    Console.WriteLine($"Bättre lyka nästa gång {name}. Du fick {rätt} frågor rätt.");
}else if (rätt == 1)
{
    Console.WriteLine($"Bättre lyka nästa gång {name}. Du fick {rätt} fråga rätt.");
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