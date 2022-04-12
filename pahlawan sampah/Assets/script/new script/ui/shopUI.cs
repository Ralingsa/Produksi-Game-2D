using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shopUI : MonoBehaviour
{
    public Text uang;
    // Start is called before the first frame update
    void Start()
    {
        uang.text = "Rp. " + data.uang.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
