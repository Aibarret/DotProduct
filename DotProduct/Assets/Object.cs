using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object : MonoBehaviour
{
    public GameObject player;
    public GameObject dotTest;
    

    public float dotTestNumber;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        float dot = Vector3.Dot(new Vector3(1, 0, 0), Vector3.Normalize(player.transform.position - transform.position));
        if (dot < -.01)
        {
            print("Ding!!!");
        }
    }



    private void OnDrawGizmos()
    {
        float dot = Vector3.Dot(new Vector3(1, 0, 0), Vector3.Normalize(dotTest.transform.position - transform.position));
        Gizmos.DrawLine(transform.position, dotTest.transform.position);
        Gizmos.DrawWireSphere(dotTest.transform.position, .25f);
        dotTestNumber = dot;
    }
}
