using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformLvl1_1_n4 : MonoBehaviour
{
    private bool collided;
    public bool hasFallen;

    private bool alreadyMoved;

    private Vector3 pos;
    private Vector3 newPos;

    [SerializeField] private GameObject platform3;

    private Vector3 velocity = Vector3.zero;
    private float smoothTime = 0.1f;

    void Start()
    {
        pos = platform3.transform.position;
        newPos = platform3.transform.position + new Vector3(-2.37f, 0f, 0f);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            collided = true;
        }
    }

    void Update()
    {   
        if (collided == true && alreadyMoved == false)
        {
            platform3.transform.position = Vector3.SmoothDamp(platform3.transform.position, newPos, ref velocity, smoothTime);
            hasFallen = true;
            StartCoroutine(ReturnToPosAfterDelay());
        }
    }

    IEnumerator ReturnToPosAfterDelay()
    {
        yield return new WaitForSeconds(1f);
        collided = false;
        platform3.transform.position = Vector3.SmoothDamp(platform3.transform.position, pos, ref velocity, smoothTime);
        alreadyMoved = true;
    }
}