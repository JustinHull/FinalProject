using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    public GameObject bossProjectilePrefab;
    public Transform firePoint;
    public float timer;
    public int waitingTime;
    


    void Update()
    {
        timer += Time.deltaTime;

        if (timer > waitingTime)
        {
            GameObject newProjectile = Instantiate(bossProjectilePrefab, firePoint.position, firePoint.rotation);

            timer = 0;
        }
    }

}
