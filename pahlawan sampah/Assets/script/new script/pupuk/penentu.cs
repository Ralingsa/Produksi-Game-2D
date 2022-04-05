using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class penentu : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("start");
        //moveUp();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= -0.04f)
        {
            moveUp();
        }

        if (transform.position.y >= 0.4f)
        {
            moveDown();
        }


    }

    void moveUp()
    {
        Vector2 pos = transform.position;
        pos.y += speed * Time.deltaTime;
        transform.position = pos;
    }

    void moveDown()
    {
        Vector2 pos = transform.position;
        pos.y -= speed * Time.deltaTime;
        transform.position = pos;
    }
}
