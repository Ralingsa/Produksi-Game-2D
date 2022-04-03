using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class munculBotol : MonoBehaviour
{
    public GameObject botol;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(botol, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        {
            if (Input.GetMouseButtonUp(0))
            {
                Instantiate(botol, transform.position, transform.rotation);
            }
        }
    }
}
