using System;

Random generator = new Random();

Console.WriteLine("Gissa på ett nummer mellan 1 - 10");

int rand = generator.Next(1, 11);
int gissning = -1;

while (!(gissning > 0 && gissning < 11))
{
    try
    {
        gissning = Convert.ToInt32(Console.ReadLine());
    }
    catch (Exception ex)
    {
        Console.WriteLine("Ett fel inträffade. Ange ett positivt heltal!");
    }
}

if (gissning == rand)
{
    Console.WriteLine("Grattis, du gissade rätt");
    Console.ReadLine();
}
else
{
    Console.WriteLine($"Du gissade fel, bättre lycka nästa gång! Rätt nummer var {rand}");
    Console.WriteLine("Tryck på ENTER för att avsluta");
    Console.ReadLine();
}

