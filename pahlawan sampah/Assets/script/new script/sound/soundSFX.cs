using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundSFX : MonoBehaviour
{
    public AudioClip destroy;
    private AudioSource destroySource;
    public bool organik;
    // Start is called before the first frame update
    void Start()
    {
        destroySource = gameObject.AddComponent<AudioSource>();
        destroySource.clip = destroy;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("sm organik") && organik)
        {
            //Debug.Log("botol1");
            destroySource.Play();
        }
        if (collision.tag.Equals("sm anorganik") && !organik)
        {
            destroySource.Play();
        }
    }
}
