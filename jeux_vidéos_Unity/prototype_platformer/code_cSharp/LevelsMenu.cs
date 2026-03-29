using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelsMenu : MonoBehaviour
{   
    [SerializeField] private GameObject level1Text;
    [SerializeField] private GameObject level2Text;
    [SerializeField] private GameObject level3Text;

    [SerializeField] private GameObject niveau1Text;
    [SerializeField] private GameObject niveau2Text;
    [SerializeField] private GameObject niveau3Text;

    [SerializeField] private GameObject backText;
    [SerializeField] private GameObject retourText;

    void Awake()
    {
        if (Application.systemLanguage == SystemLanguage.English)
        {
            level1Text.SetActive(true);
            level2Text.SetActive(true);
            level3Text.SetActive(true);
            backText.SetActive(true);
        }
        else if (Application.systemLanguage == SystemLanguage.French)
        {
            niveau1Text.SetActive(true);
            niveau2Text.SetActive(true);
            niveau3Text.SetActive(true);
            retourText.SetActive(true);
        }
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void LoadLvl1()
    {
        SceneManager.LoadScene("Lvl 1-1");
    }
}
