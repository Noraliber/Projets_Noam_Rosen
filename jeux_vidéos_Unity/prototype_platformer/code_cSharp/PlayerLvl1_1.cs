using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLvl1_1 : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -8.6f)
        {
            transform.position = new Vector3(-8.6f, transform.position.y, transform.position.z);
        }
        else if (transform.position.x > 8.74f)
        {
            transform.position = new Vector3(8.74f, transform.position.y, transform.position.z);
        }
    }
}