using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTeleport : MonoBehaviour
{
    private GameObject currentTeleporter;

    public bool isTeleporting; // For audio

    void Update()
    {
        if (Input.GetButtonDown("Teleport"))
        {
            if (currentTeleporter != null)
            {
                transform.position = currentTeleporter.GetComponent<Teleporter>().GetDestination().position;
                StartCoroutine(IsTeleporting());
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Teleporter")
        {
            currentTeleporter = other.gameObject;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Teleporter")
        {
            if (other.gameObject == currentTeleporter)
            {
                currentTeleporter = null;
            }
        }
    }

    IEnumerator IsTeleporting()
    {
        isTeleporting = true;
        yield return new WaitForSeconds(1/60);
        isTeleporting = false;
    }
}