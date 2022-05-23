using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shopCtrl : MonoBehaviour
{
    public int harga;
    int uang;
    //public GameObject terjual, gagal;
    public Text uangTxt;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void clickJual()
    {
        uang= uang +harga;
        uangTxt.text = "Rp. " + uang;
    }
}
