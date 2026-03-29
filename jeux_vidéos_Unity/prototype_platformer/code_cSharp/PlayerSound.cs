using System.Collections;
using UnityEngine;
using UnityEngine.Audio;

public class PlayerSound : MonoBehaviour
{   
    [SerializeField] private GameObject jumpPad;
    [SerializeField] private GameObject TeleporterSoundObject;
    [SerializeField] private GameObject ladderSoundObject;

    private bool ladderPlayed;

    void Update()
    {   
        JumpSound();
        JumpPadSound();
        TeleportSound();
        LadderSound();
    }

    void JumpSound()
    {
        if (gameObject.GetComponent<PlayerMovement>().isJumping == true || gameObject.GetComponent<PlayerMovement>().isWallJumpingAudio == true)  
        {
            gameObject.GetComponent<AudioSource>().Play();
        }
    }

    void JumpPadSound()
    {
        if (jumpPad.GetComponent<JumpPad>().isBouncing == true)
        {
            jumpPad.GetComponent<AudioSource>().Play();
        }
    }

    void TeleportSound()
    {
        if (gameObject.GetComponent<PlayerTeleport>().isTeleporting == true)
        {
            TeleporterSoundObject.GetComponent<AudioSource>().Play();
        }
    }

    void LadderSound()
    {
        if (gameObject.GetComponent<LadderMovement>().isMoving == true)
        {   
            if (ladderPlayed == false)
            {
                ladderSoundObject.GetComponent<AudioSource>().Play();
                ladderPlayed = true;            
            }
        }
        else
        {
            ladderSoundObject.GetComponent<AudioSource>().Stop(); 
            ladderPlayed = false;           
        }
    }
}