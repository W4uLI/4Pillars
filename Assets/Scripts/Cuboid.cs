using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cuboid 
{
    // ENCAPSULATION
    public string cuboidName { get; set; }
    public int health { get; set; }
    public int maxHealth { get; set; }
    public Color color { get; set; }

    public Cuboid()
    {}
    //POLYMORPHISM
    public Cuboid(string name, int health, Color color)
    {
        cuboidName = name;
        this.health = health;
        this.color = color;
    }
    //POLYMORPHISM
    public Cuboid(string name, int health, int maxHealth)
    {
        cuboidName = name;
        this.health = health;
        this.maxHealth = maxHealth;
    }
    //POLYMORPHISM
    public virtual void HealCuboid(int amount)
    {
        this.health += amount;
    }
    //POLYMORPHISM
    public virtual void HurtCuboid(int amount)
    {      
        health -= amount;      
    }

    
}
