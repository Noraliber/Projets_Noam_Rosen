using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{   
    [SerializeField] private GameObject playText;
    [SerializeField] private GameObject creditsText;
    [SerializeField] private GameObject quitText;

    [SerializeField] private GameObject jouerText;
    [SerializeField] private GameObject creditsTextFR;
    [SerializeField] private GameObject quitterText;

    void Awake()
    {
        if (Application.systemLanguage == SystemLanguage.English)
        {
            playText.SetActive(true);
            creditsText.SetActive(true);
            quitText.SetActive(true);
        }
        else if (Application.systemLanguage == SystemLanguage.French)
        {
            jouerText.SetActive(true);
            creditsTextFR.SetActive(true);
            quitterText.SetActive(true);
        }
    }

    public void Play()
    {
        SceneManager.LoadScene("Levels Menu");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
