using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakeGround : MonoBehaviour
{
    private float destroyDelay = 15f;

    private bool playAudio = true;
    public bool hasFallen;

    [SerializeField] private Rigidbody2D rb;

    void OnTriggerEnter2D(Collider2D other)
    {   
        if (other.tag == "Player")
        {
            Fall();
        }
    }

    public void Fall()
    {
        rb.bodyType = RigidbodyType2D.Dynamic;
        rb.gravityScale = 3f;
        if (playAudio == true)
        {
            gameObject.GetComponent<AudioSource>().Play();
            playAudio = false;
        }
        hasFallen = true;
        Destroy(gameObject, destroyDelay);   
    }
}