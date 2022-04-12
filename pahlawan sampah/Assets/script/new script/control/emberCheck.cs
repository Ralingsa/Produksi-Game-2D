using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class emberCheck : MonoBehaviour
{
    public GameObject emberKosong, ember2, ember3, ember4, emberPenuh;
    int takar, takar2, takar3, takar4, penuh;
    //bool tanahIn;
    int tanah;
    bool sampahOk;
    int sampahCount;
    bool tanahIn;
    public AudioClip destroy;
    AudioSource destroyClip;

    // Start is called before the first frame update
    void Start()
    {
        tanah = 0;
        //sampahCount = 0;
        //takar = data.Or_count / 3;
        //takar2 = takar;
        //takar3 = takar2 + takar;
        //takar4 = takar4 + takar3;
        tanahIn = false;
        sampahOk = false;
        setKosong();

        destroyClip = gameObject.AddComponent<AudioSource>();
        destroyClip.clip = destroy;

        //Debug.Log(takar + ", " + takar2 + ", " + takar3 + ", " + takar4);
        //Debug.Log(tanahIn + ", " + sampahOk+", ");
    }

    // Update is called once per frame
    void Update()
    {
        //tanahCheck();
        //sampahCheck();

        if (tanahIn)
        {
            if (tanah >= 2)
            {
                setPenuh();
                gameObject.GetComponent<muncultanah>().gameObject.SetActive(false);
            }
            else
            {
                setEmber2();
            }
            tanahIn = true;
        }
        if (data.Or_count == 0)
        {
            tanahIn = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("sm organik"))
        {
            if (tanahIn)
            {
                sampahCount++;
                Destroy(collision.gameObject);
                data.Or_count--;
                destroyClip.Play();
            }
        }

        if (collision.tag.Equals("tanah"))
        {
            if (!tanahIn)
            {
                tanah++;
                Destroy(collision.gameObject);
                tanahIn = true;
                destroyClip.Play();
            }
        }
    }

    void tanahCheck()
    {
        if ( tanahIn)
        {
            setEmber2();
            //tanahIn = true;
        }
        if (tanah == 2 && tanahIn)
        {
            setEmber3();
            //tanahIn = true;
        }
        if (tanah == 3 && tanahIn)
        {
            setEmber4();
            //tanahIn = true;
        }
        if (tanah == 4 && tanahIn)
        {
            setPenuh();
            //data.pupukCount++;
            sampahCount++;
            //tanahIn = true;
        }
    }

    void sampahCheck()
    {
        if (sampahCount ==2)
        {
            sampahOk = true;
        }
        else 
        {
            sampahOk = false;
            tanahIn = false;
        }
    }
    void setEmber2()
    {
        emberKosong.SetActive(false);
        ember2.SetActive(true);
        ember3.SetActive(false);
        ember4.SetActive(false);
        emberPenuh.SetActive(false);
    }

    void setEmber3()
    {
        emberKosong.SetActive(false);
        ember2.SetActive(false);
        ember3.SetActive(true);
        ember4.SetActive(false);
        emberPenuh.SetActive(false);
    }

    void setEmber4()
    {
        emberKosong.SetActive(false);
        ember2.SetActive(false);
        ember3.SetActive(false);
        ember4.SetActive(true);
        emberPenuh.SetActive(false);
    }

    void setPenuh()
    {
        emberKosong.SetActive(false);
        ember2.SetActive(false);
        ember3.SetActive(false);
        ember4.SetActive(false);
        emberPenuh.SetActive(true);
        data.pupukCount++;
    }

    void setKosong()
    {
        emberKosong.SetActive(true);
        ember2.SetActive(false);
        ember3.SetActive(false);
        ember4.SetActive(false);
        emberPenuh.SetActive(false);
    }
}
