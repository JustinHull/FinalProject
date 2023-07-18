using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;
    private float forwardInput;
    public float speed;
    public float turnSpeed;
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

        // Moves the player
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // Rotates the player
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);

        // Plays forwards animation by setting "isForwards" to true when you press w
        if (Input.GetKey("w"))
        {
            animator.SetBool("isForwards", true);
        }
        // Goes back to idle by setting "isForwards" to false when you are not pressing w
        if(!Input.GetKey("w"))
        {
            animator.SetBool("isForwards", false);
        }

        // Plays Backwards animation by setting "isBackwards" to true when you press s
        if (Input.GetKey("s"))
        {
            animator.SetBool("isBackwards", true);
        }
        // Goes back to idle by setting "isBackwards" to false when you are not pressing s
        if (!Input.GetKey("s"))
        {
            animator.SetBool("isBackwards", false);
        }
       
    }
}
