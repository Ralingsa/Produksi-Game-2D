using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anorganikCheck : MonoBehaviour
{
    public string id;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("NonOraganik"))
        {
            //Debug.Log("botol1");
            saveAnorganik();
            data.sampahIn++;
            Destroy(this.gameObject);
        }
    }

    void saveAnorganik()
    {
        if (id == "botol 2")
        {
            data.An_Bot2++;
            Debug.Log(id + "_saved: " + data.An_Bot2);
        }
        if (id =="kotak makan")
        {
            data.An_KotMak++;
            Debug.Log(id + "_saved: " + data.An_KotMak);
        }
        if (id == "kotak")
        {
            data.An_Kot++;
            Debug.Log(id + "_saved: " + data.An_Kot);
        }
        if (id == "kertas")
        {
            data.An_Ker++;
            Debug.Log(id + "_saved: " + data.An_Ker);
        }
    }
}
