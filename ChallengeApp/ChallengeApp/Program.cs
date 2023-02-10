string name = "Klaudia";
string sex = "kobieta";
var age = 37;

// Komunikat 1
if (sex == "kobieta" && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (sex == "kobieta" && age > 30)
{
    Console.WriteLine("Kobieta powyżej 30 lat");
}
else if (sex == "kobieta" && age == 30)
{
    Console.WriteLine("Kobieta 30 lat");
}
else if (sex == "mężczyzna" && age < 30)
{
    Console.WriteLine("Mężczyzna poniżej 30 lat");
}
else if (sex == "mężczyzna" && age > 30)
{
    Console.WriteLine("Mężczyzna powyżej 30 lat");
}
else if (sex == "mężczyzna" && age == 30)
{
    Console.WriteLine("Mężczyzna 30 lat");
}

// Komunikat 2
Console.WriteLine(name + ", lat " + age);

// Komunikat 3
if (age < 18)
{
    if (sex == "kobieta")
    {
        Console.WriteLine("Niepełnoletnia kobieta");
    }
    else if (sex == "mężczyzna")
    {
        Console.WriteLine("Niepełnoletni mężczyzna");
    }
}
else
{
    if (sex == "kobieta")
    {
        Console.WriteLine("Pełnoletnia kobieta");
    }
    else if (sex == "mężczyzna")
    {
        Console.WriteLine("Pełnoletni mężczyzna");
    }
}
