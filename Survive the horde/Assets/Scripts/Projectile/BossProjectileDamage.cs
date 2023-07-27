using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossProjectileDamage : MonoBehaviour
{
    public int damage = 100;

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.GetComponent<Health>() != null)
        {
            Health health = collider.GetComponent<Health>();
            health.Damage(damage);

            Destroy(gameObject);
        }
    }
}
