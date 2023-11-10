using System;
public class Fighter
{
    public int Health = 100;

    public string name;

public Weapon weapon;


public void Attack(Fighter target)
{
int damage = weapon.GetDamage();
target.Health -= damage;
target.Health = Math.Max(0, target.Health);
Console.WriteLine($"{name} gör {damage} skada på {target.name}");   

}

}
