using System;
public class Fighter
{
    public int Health = 100;  // Börjar med 100 hp

    public string name;  
 
public Weapon weapon; // Vapnet till stridaren 


public void Attack(Fighter target)    // En metod som som utför en attack på varrandra 
{
int damage = weapon.GetDamage();  // Hämtar skada från stridaren vapen 
target.Health -= damage;   // minskar hp 
target.Health = Math.Max(0, target.Health);  // hp får inte gå under 0
Console.WriteLine($"{name} gör {damage} skada på {target.name}");  // självaste attacken 

}

}
