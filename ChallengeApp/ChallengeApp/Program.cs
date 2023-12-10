var name = "Tomasz";
var age = 17;
var gender = "man";

if (name is string)
{
    Console.WriteLine("Variable name is string");
}

if (age is int)
{
    Console.WriteLine("Variable age is int");
}

if (gender is string)
{
    Console.WriteLine("Variable gender is string");
}

if((age < 30) && (gender =="woman"))
{
    Console.WriteLine("Koieta poniżej 30 lat");
}

if ((name == "Ewa") && (age == 33))
{
    Console.WriteLine("Ewa, lat 33");
}

if ((age < 18)&&(gender=="man"))
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
