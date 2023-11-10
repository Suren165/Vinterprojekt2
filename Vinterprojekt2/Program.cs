using System;

Fighter hero = new Fighter();
hero.name = "Riddaren";
hero.weapon = new Weapon();
hero.weapon.name = "Boxar";

Fighter Villain = new Fighter();
Villain.name = "Trollet";
hero.weapon = new Weapon();
hero.weapon.name = "Boxar";

Random generator = new Random();

while (hero.Health > 0 && Villain.Health > 0)
{
  Console.WriteLine("\n----- ===== NY RUNDA ===== -----");
  Console.WriteLine($"{hero.name}: {hero.Health}  {Villain.name}: {Villain.Health}\n");

  int heroDamage = generator.Next(30);
  Villain.Health -= heroDamage;
  Villain.Health = Math.Max(0, Villain.Health);
  Console.WriteLine($"{hero.name} gör {heroDamage} skada på {Villain.name}");

  int villainDamage = generator.Next(20);
  hero.Health -= villainDamage;
  hero.Health = Math.Max(0, hero.Health);
  Console.WriteLine($"{Villain.name} gör {villainDamage} skada på {hero.name}");

  Console.WriteLine("Tryck på vilken knapp du vill för att fortsätta.");
  Console.ReadKey();
}

Console.WriteLine("\n----- ===== STRIDEN ÄR SLUT ===== -----");

if (hero.Health == 0 && Villain.Health == 0)
{
  Console.WriteLine("OAVGJORT");
}
else if (hero.Health == 0)
{
  Console.WriteLine($"{Villain.name} vann!");
}
else
{
  Console.WriteLine($"{hero.name} vann!");
}

Console.WriteLine("Tryck på vilken knapp du vill för att fortsätta.");
Console.ReadKey();
