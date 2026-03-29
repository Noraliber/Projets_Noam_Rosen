using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialUI : MonoBehaviour
{   
    [SerializeField] private GameObject azertyMoveUI;
    [SerializeField] private GameObject frenchJumpUI;

    [SerializeField] private GameObject qwertyMoveUI;
    [SerializeField] private GameObject englishJumpUI;
    
    void Start()
    {
        if (Application.systemLanguage == SystemLanguage.French)
        {
            azertyMoveUI.SetActive(true);
            frenchJumpUI.SetActive(true);
        }
        else if (Application.systemLanguage == SystemLanguage.English)
        {
            qwertyMoveUI.SetActive(true);
            englishJumpUI.SetActive(true);
        }
    }
}
