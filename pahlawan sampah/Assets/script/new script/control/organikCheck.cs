using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class organikCheck : MonoBehaviour
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
        if (collision.tag.Equals("Organik"))
        {
            //Debug.Log("botol1");
            saveOrganik();
            data.sampahIn++;
            Destroy(this.gameObject);
        }
    }

    void saveOrganik()
    {
        if (id == "daun 1")
        {
            data.Or_Dau1++;
            data.Or_count++;
            Debug.Log(id + "_saved: " + data.Or_Dau1);
        }
        if(id=="daun 2")
        {
            data.Or_Dau2++;
            data.Or_count++;
            Debug.Log(id + "_saved: " + data.Or_Dau2);
        }
        if (id == "ranting 2")
        {
            data.Or_Ran2++;
            data.Or_count++;
            Debug.Log(id + "_saved: " + data.Or_Ran2);
        }
    }
}
