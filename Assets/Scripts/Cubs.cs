using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubs : Cuboid
{
    // INHERITANCE 
    public Cubs() { }
    //POLYMORPHISM
    public Cubs(string name, int health, Color color)
    {
        cuboidName = name;
        this.health = health;
        this.color = color;
    }
    //POLYMORPHISM
    public Cubs(string name, int health, int maxHealth)
    {
        cuboidName = name;
        this.health = health;
        this.maxHealth = maxHealth;
    }
    
    public override void HealCuboid(int amount) // whenever you use heal on a cubs it also adds more hp to the max health possible.
    {
        this.maxHealth += 2;
        base.HealCuboid(amount);
    }
}
