using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboidController : MonoBehaviour
{
    private Cuboid cuboid;
    public Color[] color;
    void Start()
    {
        SetUpCuboid();
    }


    private void OnMouseDown()
    {
        Debug.Log(cuboid.cuboidName + " " + cuboid.health + " " + cuboid.maxHealth);
    }

    void SetUpCuboid()
    {
        //ABSTRACTION
        cuboid = new Cuboid();
        cuboid.cuboidName = gameObject.name;
        cuboid.maxHealth = Random.Range(100, 300);
        cuboid.health = cuboid.maxHealth;
        //can't use Random.range in constructor somehow, so I assigned it all one by one, making sure the current health is like the random max health

        int i = Random.Range(0, color.Length);
        cuboid.color = color[i];
        gameObject.GetComponent<Renderer>().material.color = cuboid.color;
    }
}
