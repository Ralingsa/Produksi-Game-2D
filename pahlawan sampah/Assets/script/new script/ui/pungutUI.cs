using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pungutUI : MonoBehaviour
{
    public GameObject modGuide;
    // Start is called before the first frame update
    void Start()
    {
        modGuide.SetActive(true);
    }

    public void closemodGuide()
    {
        modGuide.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
