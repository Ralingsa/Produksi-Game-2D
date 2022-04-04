using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anorganikCheck : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("NonOrganik"))
        {
            Destroy(this.gameObject);
        }
    }
}
