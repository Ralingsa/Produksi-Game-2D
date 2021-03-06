using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pungut1 : MonoBehaviour
{
    public GameObject[] organik;
    public GameObject[] anorganik;
    public int limitSampah;
    int sampah;
    int spawn;
    public Text limitTxt;
    public GameObject modFinish;
    public GameObject home;
    
    // Start is called before the first frame update
    void Start()
    {
        setStart();
        modFinish.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        sampah = data.sampahIn;
        while (spawn <= limitSampah)
        {
            spawnSampahOrganik();
            spawnSampahAnorganik();
        }
        limitTxt.text = sampah.ToString() + "/" + data.limit.ToString();

        if (sampah == data.limit)
        {
            modFinish.SetActive(true);
            home.SetActive(false);
        }
    }

    public void spawnSampahOrganik()
    {
        int index = Random.Range(0, organik.Length);
        Instantiate(organik[index], new Vector2(Random.Range(-8f, 8f), Random.Range(-1.5f, -5f)), transform.rotation);
        spawn++;
    }

    public void spawnSampahAnorganik()
    {
        int index = Random.Range(0, anorganik.Length);
        Instantiate(anorganik[index], new Vector2(Random.Range(-8f, 8f), Random.Range(-1.5f, -5f)), transform.rotation);
        spawn++;
    }

    void setStart()
    {
        data.sampahIn = 0;
        data.Or_count = 0;

        data.An_Bot2 = 0;
        data.An_KotMak = 0;
        data.An_Kot = 0;
        data.An_Ker = 0;

        data.Or_Dau1 = 0;
        data.Or_Dau2 = 0;
        data.Or_Ran2 = 0;

        data.limit = limitSampah + 1;
    }
}
