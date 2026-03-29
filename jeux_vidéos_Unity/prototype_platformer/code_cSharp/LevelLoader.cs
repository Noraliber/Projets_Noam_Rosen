using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{   
    [SerializeField] private GameObject player;

    [SerializeField] private GameObject[] nextLevelTextsEn;
    [SerializeField] private GameObject[] nextLevelTextsFr;
    private GameObject currentNextLevelText;

    [SerializeField] private GameObject[] gameOverTextsEn;
    [SerializeField] private GameObject[] gameOverTextsFr;
    private GameObject currentGameOverText;

    public float transitionTime = 1f;

    public Animator nextLevelTransition;
    public Animator gameOverTransition;

    [SerializeField] private GameObject crossfadeObject;
    [SerializeField] private GameObject circleWipeObject;

    [SerializeField] private TransitionData loadReason;

    void Awake()
    {   
        if (loadReason.loadReasonValue == "next level")
        {
            crossfadeObject.SetActive(true);
        }
        if (loadReason.loadReasonValue == "game over")
        {
            circleWipeObject.SetActive(true);
        }

        if (Application.systemLanguage == SystemLanguage.English)
        {
            currentGameOverText = gameOverTextsEn[Random.Range(0, gameOverTextsEn.Length)];
            currentNextLevelText = nextLevelTextsEn[Random.Range(0, nextLevelTextsEn.Length)];
        }
        else if (Application.systemLanguage == SystemLanguage.French)
        {
            currentGameOverText = gameOverTextsFr[Random.Range(0, gameOverTextsFr.Length)];
            currentNextLevelText = nextLevelTextsFr[Random.Range(0, nextLevelTextsFr.Length)];
        }
    }

    void Update()
    {   
        if (player.GetComponent<PlayerNextLevel>().nextLevel == true)
        {   
            crossfadeObject.SetActive(true);
            LoadNextLevel();
        }
        else if (player.GetComponent<PlayerNextLevel>().levelsMenu == true)
        {   
            crossfadeObject.SetActive(true);
            LoadLevelsMenu();
        }
        if (player.GetComponent<PlayerGameOver>().gameOver == true)
        {   
            circleWipeObject.SetActive(true);
            GameOver();
        }
    }

    void LoadNextLevel()
    {   
        currentNextLevelText.SetActive(true);
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    void LoadLevelsMenu()
    {   
        StartCoroutine(LoadLevel(1));
    }

    void GameOver()
    {   
        currentGameOverText.SetActive(true);
        StartCoroutine(ReloadLevel());
    }

    IEnumerator ReloadLevel()
    {   
        gameOverTransition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    IEnumerator LoadLevel(int leveIndex)
    {   
        nextLevelTransition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(leveIndex);
    }

    IEnumerator DataReset()
    {
        yield return new WaitForEndOfFrame();
        loadReason.loadReasonValue = "";
    }
}
