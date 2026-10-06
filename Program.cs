// See https://aka.ms/new-console-template for more information

//          Páros számok összege

/* 
Console.WriteLine("Kezdőérték: ");
int elso = int.Parse(Console.ReadLine());

Console.WriteLine("Záró érték: ");
int masodik = int.Parse(Console.ReadLine());

int osszeg = 0;
for (int i= elso; i<=masodik;i+=2)
{
    Console.WriteLine(i);
    osszeg = osszeg + i;
};
Console.WriteLine(osszeg);
*/

//          Príma nyereményjáték

/*
Console.WriteLine("Sorszám: ");
int szam = int.Parse(Console.ReadLine());

bool prim = true;

if (szam<=1)
{
    
}
else
{
    for (int i = 2; i < szam; i++)
    {
        if (szam % i == 0)
        {
            prim = false;
            break;
        }
    }
}

if (prim=true)
{
    Console.WriteLine("Gratulalok, nyertel!");
}
else
{
    Console.WriteLine("Sajnos nem nyert!");
}
*/

//          Szorzótábla


for (int i=1; i<=10; i++)
{
    for (int j=1; j<=10; j++)
    {
        Console.WriteLine(i*j, " ");
    }
    Console.WriteLine();
}