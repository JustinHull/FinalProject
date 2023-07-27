using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossPowerHealth : MonoBehaviour
{
    [SerializeField] private int health = 30;

    // Update is called once per frame
    void Update()
    {

    }

    public void BossPowerDamage(int amount)
    {
        if (amount < 0)
        {
            throw new System.ArgumentOutOfRangeException("Cannot have negative Damage");
        }
        this.health -= amount;

        if (health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Debug.Log("Enemy dead");
        Destroy(gameObject);
    }
}
