using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformLvl1_4_n2 : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject disappearSound;

    public Animator platformDisappear;

    private bool hasPlayed;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player" && player.GetComponent<PlayerLvl1_4>().stage == 5)
        {
            player.GetComponent<PlayerLvl1_4>().stage = 6;
        }
        else
        {
            platformDisappear.SetTrigger("Start");
            if (hasPlayed == false)
            {
                disappearSound.GetComponent<AudioSource>().Play();
                // hasPlayed = true;
            }
            StartCoroutine(DestroyObject());
        }
    }

    IEnumerator DestroyObject()
    {   
        yield return new WaitForSeconds(0.1f);
        gameObject.SetActive(false);
    }
}
