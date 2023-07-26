using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
   [SerializeField] private int health = 100;
    public HealthBar healthBar;

    void Start()
    {
        healthBar.SetMaxHealth(health);   
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Damage(int amount)
    {
        
        this.health -= amount;
        healthBar.SetHealth(health);

        if (health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Debug.Log("You died");
        Destroy(gameObject);
    }
}
