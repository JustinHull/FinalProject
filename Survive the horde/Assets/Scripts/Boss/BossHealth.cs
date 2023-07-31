using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossHealth : MonoBehaviour
{
    [SerializeField] private int health = 200;

    // Update is called once per frame
    void Update()
    {

    }

    public void BossDamage(int amount)
    {
        if (amount < 0)
        {
            throw new System.ArgumentOutOfRangeException("Cannot have negative Damage");
        }
        this.health -= amount;

        if (health <= 0)
        {
            Die();
            SceneManager.LoadScene("Win Screen");
        }
    }

    private void Die()
    {
        Debug.Log("GOD SLAYED");
        Destroy(gameObject);
    }
}
