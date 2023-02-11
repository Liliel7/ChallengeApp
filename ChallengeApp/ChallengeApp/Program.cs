string name = "Klaudia";
bool isWoman = true;
var age = 37;

// Komunikat 1
if (isWoman == true && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (isWoman == true && age > 30)
{
    Console.WriteLine("Kobieta powyżej 30 lat");
}
else if (isWoman == true && age == 30)
{
    Console.WriteLine("Kobieta 30 lat");
}
else if (isWoman == false && age < 30)
{
    Console.WriteLine("Mężczyzna poniżej 30 lat");
}
else if (isWoman == false && age > 30)
{
    Console.WriteLine("Mężczyzna powyżej 30 lat");
}
else if (isWoman == false && age == 30)
{
    Console.WriteLine("Mężczyzna 30 lat");
}

// Komunikat 2
Console.WriteLine(name + ", lat " + age);

// Komunikat 3
if (age < 18)
{
    if (isWoman == true)
    {
        Console.WriteLine("Niepełnoletnia kobieta");
    }
    else if (isWoman == false)
    {
        Console.WriteLine("Niepełnoletni mężczyzna");
    }
}
else
{
    if (isWoman == true)
    {
        Console.WriteLine("Pełnoletnia kobieta");
    }
    else if (isWoman == false)
    {
        Console.WriteLine("Pełnoletni mężczyzna");
    }
}
