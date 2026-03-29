using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGameOver : MonoBehaviour
{   
    public bool gameOver;

    [SerializeField] private TransitionData loadReason;

    void Update()
    {
        if (transform.position.y <= -5.4f)
        {   
            gameOver = true;
            loadReason.loadReasonValue = "game over";
        }
    }
}