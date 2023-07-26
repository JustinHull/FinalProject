using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 10f;

        // Set the direction for the projectile to move.
        public void SetDirection(Vector3 direction)
    {
        transform.forward = direction.normalized;
    }

    void Update()
    {
        // Move the projectile forward in its local space (in the direction it's facing).
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

    }

    void OnTriggerEnter(Collider other)
    {
        // Check if the projectile collides with a boundary (you need to tag the boundary colliders as "Boundary" or change the tag below accordingly).
        if (other.CompareTag("Boundary"))
        {
            Destroy(gameObject); // Destroy the projectile game object when it hits a boundary.
        }
    }
}
