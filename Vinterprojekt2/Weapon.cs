using System;
using System.Security.AccessControl;
public class Weapon
{
    public string name;

private Random generator;


public Weapon() 

{
generator = new ();
}

public int  GetDamage()
{
return generator.Next(10,30);
}

}