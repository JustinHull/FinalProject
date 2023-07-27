using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMoveForward : MonoBehaviour
{
    public float speed = 5f;

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
