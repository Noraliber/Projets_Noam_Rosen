using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformLvl1_4_n5 : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject disappearSound;
    [SerializeField] private GameObject platform1;

    public bool platform5Disappear;
    private bool hasPlayed;

    public Animator platformDisappear;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player" && player.GetComponent<PlayerLvl1_4>().stage == 3)
        {
            player.GetComponent<PlayerLvl1_4>().stage = 4;
        }
        else
        {
            platform5Disappear = true;
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
        platform1.SetActive(false);
    }
}
