using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubsController : MonoBehaviour
{
    private Cubs cubs;
    private bool isAlive;
    public Slider hpBar;
    private void Start()
    {
        isAlive = true;
        //ABSTRACTION
        cubs = new Cubs();
        cubs.cuboidName = gameObject.name;
        cubs.maxHealth = Random.Range(100, 150);
        cubs.health = cubs.maxHealth;

        
    }

    private void Update()
    {
        UpdateHPBar();
    }

    private void OnMouseOver()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            cubs.HealCuboid(Random.Range(10, 50));
            Debug.Log(cubs.cuboidName + " is happy that you heal it!");
            ConsolePrintCurrentHealth();
            UpdateHPBar();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            if(isAlive)
            {
                if (cubs.health <= 0)
                {
                    isAlive = false;
                    KillCubs();
                }
                cubs.HurtCuboid(Random.Range(10, 50));
                Debug.Log("You are hurting " + cubs.cuboidName + "!");
                ConsolePrintCurrentHealth();
                UpdateHPBar();                
            }         
        }
    }

    void ConsolePrintCurrentHealth()
    {
        Debug.Log(cubs.cuboidName + "'s health is: " + cubs.health + " and it's max health is at:  " + cubs.maxHealth);
    }

    private void KillCubs()
    {
        Object.Destroy(gameObject);
    }

    private void UpdateHPBar()
    {
        hpBar.maxValue = cubs.maxHealth;
        hpBar.value = cubs.health;
    }
}
