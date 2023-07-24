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
}
