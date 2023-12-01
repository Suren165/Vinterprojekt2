using System;
using System.Security.Cryptography;

Fighter hero = new Fighter(); // Egenskap av min hjälte
hero.name = "Riddaren";
hero.weapon = new Weapon();


Fighter Villain = new Fighter(); // Egenskaper av min skurk
Villain.name = "Trollet";
hero.weapon = new Weapon();


Random generator = new Random(); //Skapar en slump 

while (hero.Health > 0 && Villain.Health > 0)   // En loop där spelet spelas till någon har 0 hp
{
  Console.WriteLine("\n----- ===== NY RUNDA ===== -----");
  Console.WriteLine($"{hero.name}: {hero.Health}  {Villain.name}: {Villain.Health}\n");

  Console.WriteLine("Välj vapen (1 = slå) (2 = sparka)");
  string selection = Console.ReadLine();
  while (selection != "1" && selection != "2")
  {
    Console.WriteLine("Du måste välja 1 eller 2");   /// Måste välja mellan 1 och 2
    selection = Console.ReadLine();
  }          
  int heroDamage = 0;
switch (selection)   /// Istället för If och else så använder jag switch och case 
  {
    case "1":
      heroDamage = generator.Next(1,30);
      break;
    case "2":
      heroDamage = generator.Next(10,20);
      break;
  }
  Villain.Health -= heroDamage;
  Villain.Health = Math.Max(0, Villain.Health);
  Console.WriteLine($"{hero.name} gör {heroDamage} skada på {Villain.name}");

  int villainDamage = generator.Next(1,30);
  hero.Health -= villainDamage;
  hero.Health = Math.Max(0, hero.Health);
  Console.WriteLine($"{Villain.name} gör {villainDamage}  skada på {hero.name}");

  Console.WriteLine("Tryck på vilken knapp du vill för att fortsätta.");
  Console.ReadKey();
}

Console.WriteLine("\n----- ===== STRIDEN ÄR SLUT ===== -----");   // Visar slut resultat
 
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
