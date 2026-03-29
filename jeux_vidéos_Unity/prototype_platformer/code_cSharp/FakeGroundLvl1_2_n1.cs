using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakeGroundLvl1_2_n1 : MonoBehaviour
{
    [SerializeField] private GameObject platform;

    void Update()
    {
        if (platform.GetComponent<PlatformLvl1_1_n1to3>().hasFallen == true)
        {
            gameObject.GetComponent<FakeGround>().Fall();
        }
    }
}