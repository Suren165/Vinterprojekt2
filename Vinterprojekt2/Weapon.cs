using System;
using System.Collections.Generic;

public class Weapon // Den här klassen (Weapon ) representerar ett vapen som kan skada
{
    public string name; // Variabel för att lagra namnför vapnet
    private Random generator; // Slumpar ett tal
    private List<int> damageList; // En lista där den lagrar skada

    public Weapon() // Konstruktor för klassen (Weapon)
    {
        generator = new Random();   
        damageList = new List<int>();   // Skapra en nya tom lista för att lagra skada
     
    }

    public int GetDamage() // Genererar och retunerar en slumpmässig skada
    {
        int damage = generator.Next(1, 30); // Här väljer den mellan 1 - 30
        damageList.Add(damage);     // lägger till skadan i skade listan 
        return damage;    
    }

    public List<int> GetDamageList()
    {
        return damageList;
    }
}




