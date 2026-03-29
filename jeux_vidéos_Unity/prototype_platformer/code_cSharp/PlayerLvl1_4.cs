using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLvl1_4 : MonoBehaviour
{   
    public int stage;

    void Update()
    {   
        gameObject.GetComponent<PlayerMovement>().jumpingPower = 18f;

        if (transform.position.x < -17.48f)
        {
            transform.position = new Vector3(-17.48f, transform.position.y, transform.position.z);
        }
        else if (transform.position.x > 17.62f)
        {
            transform.position = new Vector3(17.62f, transform.position.y, transform.position.z);
        }
    }
}
