using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLvl1_2 : MonoBehaviour
{
    void Update()
    {
        if (transform.position.x < -14.82f)
        {
            transform.position = new Vector3(-14.82f, transform.position.y, transform.position.z);
        }
        else if (transform.position.x > 14.96f)
        {
            transform.position = new Vector3(14.96f, transform.position.y, transform.position.z);
        }        
    }
}