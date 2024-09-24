
int Player1hp = 100;
int Player2hp = 100;

string Player1name = "player1";
string Player2name = "player2";

Random generator = new Random();

while (Player1hp > 0 && Player2hp > 0)
{
Console.WriteLine("\n ____ ==== STARTA NY RUNDA ==== ____");
Console.WriteLine($"{Player1name}: {Player1hp} {Player2name}: Player2hp\n");
Console.ReadLine();

int Player1Damage = generator.Next(20);
Player2hp -= Player1Damage;
Player2hp = Math.Max(0, Player2hp);
Console.WriteLine($"{Player1name} gör {Player1Damage} skada på {Player2name}");

int Player2Damage = generator.Next(20);
Player1hp -= Player2Damage;
Player1hp = Math.Max(0, Player1hp);
Console.WriteLine($"{Player2name} gör {Player2Damage} skada på {Player1name}");

Console.WriteLine("Klicka vart du vill på ditt tangentbord för att fortsätta! (inte på avstängningsknappen)");
Console.ReadKey();
}

Console.WriteLine("\n ____ ==== Nu är Striden över ==== ____");

if (Player1hp == 0 && Player2hp == 0)
{
    Console.WriteLine("Ni Båda dog :/");

}
else if (Player1hp == 0)
{
    Console.WriteLine($"{Player2name} Har vunnit, YIPPIE!!! :D");
}
else
{
    Console.WriteLine($"{Player1name} har vunnit, TJOHOOOOOOOOOOOOOOOOOOOO !!!! ");
}

Console.WriteLine("tryck på en tangent för att avsluta (inte på avstängningsknappen tack)");
Console.ReadKey();




