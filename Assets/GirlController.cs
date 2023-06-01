using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GirlController : MonoBehaviour
{
    Rigidbody2D girlRd;
    float walkSpeed = 10.0f;

    Animator animator;
    float maxSpeed = 3.0f;

    float jumpSpeed = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        girlRd = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        animator.speed = 0f;

    }

    // Update is called once per frame
    void Update()
    {
        float speedx = Mathf.Abs(girlRd.velocity.x);
        if (Input.GetKey(KeyCode.Space) == true && transform.position.y <= -1.0f)
        {
            animator.SetTrigger("JumpCall");
            girlRd.AddForce(transform.up * jumpSpeed);
        }

        if (speedx < maxSpeed)
        {
            if (Input.GetKey(KeyCode.LeftArrow) == true)
            {
                girlRd.AddForce(transform.right * -1 * walkSpeed);
                transform.localScale = new Vector3(-1.0f, 1.0f, 1);
            }
            else if (Input.GetKey(KeyCode.RightArrow) == true)
            {
                girlRd.AddForce(transform.right * walkSpeed);
                transform.localScale = new Vector3(1.0f, 1.0f, 1);
            }
        }
        animator.speed = speedx;
    }
}

