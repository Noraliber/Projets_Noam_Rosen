using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LadderMovement : MonoBehaviour
{
    [SerializeField] private float vertical;
    private float speed = 8f;
    private bool isLadder;
    [SerializeField] private bool isClimbing;

    public bool isMoving; // For audio

    [SerializeField] private Rigidbody2D rb;

    void Update()
    {
        vertical = Input.GetAxisRaw("Vertical");

        if (isLadder == true && Mathf.Abs(vertical) > 0f)
        {
            isClimbing = true;
        }
    }

    private void FixedUpdate()
    {
        if (isClimbing == true)
        {
            rb.gravityScale = 0f;
            rb.velocity = new Vector2(rb.velocity.x, vertical * speed);

            if (vertical != 0f && gameObject.GetComponent<PlayerMovement>().IsGrounded() == false && gameObject.GetComponent<PlayerMovement>().IsWalled() == false)
            {
                isMoving = true;
            }
            else
            {
                isMoving = false;
            }
        }
        else
        {
            rb.gravityScale = 4f;
            isMoving = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Ladder")
        {
            isLadder = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Ladder")
        {
            isLadder = false;
            isClimbing = false;
        }
    }
}