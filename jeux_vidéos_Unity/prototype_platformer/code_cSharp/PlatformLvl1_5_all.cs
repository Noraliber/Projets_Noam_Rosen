using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformLvl1_5_all : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject disappearSound;
    [SerializeField] private GameObject realPlatforms;

    public Animator platformDisappear;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            platformDisappear.SetTrigger("Start");
            disappearSound.GetComponent<AudioSource>().Play();
  
            StartCoroutine(DestroyObject());
        }
    }

    IEnumerator DestroyObject()
    {   
        yield return new WaitForSeconds(0.1f);
        gameObject.SetActive(false);
        realPlatforms.SetActive(false);
    }
}