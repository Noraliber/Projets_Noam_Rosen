using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndDoor : MonoBehaviour
{   
    [SerializeField] private GameObject bNextLevel;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            bNextLevel.SetActive(true);
        }
    }
}