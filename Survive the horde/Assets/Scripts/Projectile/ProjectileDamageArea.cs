using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileDamageArea : MonoBehaviour
{

    public int damage = 10;

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.GetComponent<EnemyHealth>() != null)
        {
            EnemyHealth health = collider.GetComponent<EnemyHealth>();
            health.Damage(damage);

            Destroy(gameObject);
        }

        if (collider.GetComponent<BossPowerHealth>() != null)
        {
            BossPowerHealth health = collider.GetComponent<BossPowerHealth>();
            health.BossPowerDamage(damage);

            Destroy(gameObject);
        }

        if (collider.GetComponent<BossHealth>() != null)
        {
            BossHealth health = collider.GetComponent<BossHealth>();
            health.BossDamage(damage);

            Destroy(gameObject);
        }
    }

}