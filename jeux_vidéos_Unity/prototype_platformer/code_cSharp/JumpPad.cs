using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPad : MonoBehaviour
{
    private float bouncePower = 16f;
    public bool isBouncing; // For audio

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * bouncePower, ForceMode2D.Impulse);
            StartCoroutine(IsBouncing());
        }
    }

    IEnumerator IsBouncing() // For Audio
    {
        isBouncing = true;
        yield return new WaitForSeconds(1/60);
        isBouncing = false;
    }
}