using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakeGroundLvl1_1 : MonoBehaviour
{   
    [SerializeField] private GameObject ohText;
    [SerializeField] private GameObject noText;
    [SerializeField] private GameObject youText;
    [SerializeField] private GameObject dontText;

    [SerializeField] private GameObject player;

    [SerializeField] private AudioClip textAppearSound;
    private AudioSource sound;

    [SerializeField] private bool hasPlayed0;
    [SerializeField] private bool hasPlayed1;
    [SerializeField] private bool hasPlayed2;
    [SerializeField] private bool hasPlayed3;

    void Start()
    {
        sound = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (gameObject.GetComponent<FakeGround>().hasFallen == true)
        {   
            StartCoroutine(AppearText());
        }
    }

    IEnumerator AppearText()
    {
        yield return new WaitForSeconds(1f);
        ohText.SetActive(true);
        if (hasPlayed0 == false)
        {
            sound.PlayOneShot(textAppearSound, 0.5f);
            hasPlayed0 = true;
        }
        yield return new WaitForSeconds(1f);
        noText.SetActive(true);
        if (hasPlayed1 == false)
        {
            sound.PlayOneShot(textAppearSound, 0.5f);
            hasPlayed1 = true;
        }
        yield return new WaitForSeconds(1f);
        youText.SetActive(true);
        if (hasPlayed2 == false)
        {
            sound.PlayOneShot(textAppearSound, 0.5f);
            hasPlayed2 = true;
        }
        yield return new WaitForSeconds(1f);
        dontText.SetActive(true);
        if (hasPlayed3 == false)
        {
            sound.PlayOneShot(textAppearSound, 0.5f);
            hasPlayed3 = true;
        }
    }
}