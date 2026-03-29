using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakeGroundLvl1_3 : MonoBehaviour
{   
    private float speed = 7f;

    private bool move = false;
    
    [SerializeField] private GameObject ground0;
    [SerializeField] private GameObject ground1;
    [SerializeField] private GameObject ground2;
    [SerializeField] private GameObject ground3;
    [SerializeField] private GameObject ground4;
    [SerializeField] private GameObject ground5;
    [SerializeField] private GameObject ground6;
    [SerializeField] private GameObject ground7;

    void Update()
    {   
        if (gameObject.GetComponent<FakeGround>().hasFallen == true)
        {
            StartCoroutine(MoveGround());
        }
    }

    IEnumerator MoveGround()
    {   
        yield return new WaitForSeconds(0.5f);

        move = true;
    }

    void FixedUpdate()
    {
        if (move == true)
        {
            if (ground0.transform.position.x >= -48.3f)
            {
                ground0.transform.Translate(Vector3.left * speed * Time.deltaTime);
                ground1.transform.Translate(Vector3.left * speed * Time.deltaTime);
                ground2.transform.Translate(Vector3.left * speed * Time.deltaTime);
                ground3.transform.Translate(Vector3.left * speed * Time.deltaTime);
                ground4.transform.Translate(Vector3.left * speed * Time.deltaTime);
                ground5.transform.Translate(Vector3.left * speed * Time.deltaTime);
                ground6.transform.Translate(Vector3.left * speed * Time.deltaTime);
                ground7.transform.Translate(Vector3.left * speed * Time.deltaTime);
            }
        }
    }
}
