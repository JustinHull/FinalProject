using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;
    private float forwardInput;
    public float speed;
    public float turnSpeed;
    public GameObject projectilePrefab; 
    public Transform firePoint;

    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // Rotates the player
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            FireProjectile();
        }

    }


    void FireProjectile()
    {
        GameObject newProjectile = Instantiate(projectilePrefab, firePoint.position, firePoint.rotation);
        // Optionally set any other properties of the projectile, e.g., damage, owner, etc.
    }

    
}

