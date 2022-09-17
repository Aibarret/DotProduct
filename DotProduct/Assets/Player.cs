using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public int speed;
    public Rigidbody2D rb;
    public GameObject sign;
    public float dir;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            dir = 0;
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, -90));
            rb.MovePosition(new Vector3((transform.position.x + (speed * Time.deltaTime) * -1), transform.position.y, 0));
        }
        else if (Input.GetKey(KeyCode.D))
        {
            dir = 0;
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, 90));
            rb.MovePosition(new Vector3((transform.position.x + (speed * Time.deltaTime)), transform.position.y, 0) );
        }
        else if (Input.GetKey(KeyCode.W))
        {
            dir = 1;
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, 180));
            rb.MovePosition(new Vector3(transform.position.x, (transform.position.y + (speed * Time.deltaTime)) , 0));
        }
        else if (Input.GetKey(KeyCode.S))
        {
            dir = -1;
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
            rb.MovePosition(new Vector3(transform.position.x, (transform.position.y + (speed * Time.deltaTime) * -1), 0) );
        }


        //print(Vector3.Dot(new Vector3(0,-1,0), Vector3.Normalize(transform.position - sign.transform.position)));
        float dot = Vector3.Dot(new Vector3(0, -1, 0), Vector3.Normalize(transform.position - sign.transform.position));
        if (dot > .70)
        {
            GameObject.Destroy(sign);
        }

    }


}
