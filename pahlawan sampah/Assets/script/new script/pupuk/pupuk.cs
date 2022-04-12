using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class pupuk : MonoBehaviour
{
    int spawnD1, spawnD2, spawnR2;
    public GameObject[] organik;
    public GameObject modGuide;
    public GameObject modfinish;
    public GameObject gauge;
    public GameObject gaugeTxt;
    public Text judul;
    public Text isi;
    float valuePupuk;
    string kualitas;
    string hasilPupuk;

    // Start is called before the first frame update
    void Start()
    {
        spawnD1 = 0;
        spawnD2 = 0;
        spawnR2 = 0;
        gauge.SetActive(false);
        gaugeTxt.SetActive(false);
        modGuide.SetActive(true);
        modfinish.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        spawnOrganik();
        if (data.pupukCount == 1)
        {
            gauge.SetActive(true);
            gaugeTxt.SetActive(true);
        }
        if (data.nilaiPupuk >= 1)
        {
            valuePupuk = data.nilaiPupuk;
            if (valuePupuk <= 14)
            {
                kualitas = "KURANG BAGUS";
                hasilPupuk = "BELUM";
            }
            else
            {
                kualitas = "BAGUS";
                hasilPupuk = "SUDAH";
            }
            judul.text = "PUPUK " + hasilPupuk + " JADI";
            isi.text = "PUPUK YANG DIDIAMKAN " + valuePupuk.ToString() + "HARI ADALAH PUPUK YANG " + kualitas;
            modfinish.SetActive(true);
        }
    }

    void spawnOrganik()
    {
        while (spawnD1 < data.Or_Dau1)
        {
            Instantiate(organik[0], new Vector2(Random.Range(-7f, -3.5f), Random.Range(-3.8f, -0.8f)), transform.rotation);
            spawnD1++;
        }
        while (spawnD2 < data.Or_Dau2)
        {
            Instantiate(organik[1], new Vector2(Random.Range(-7f, -3.5f), Random.Range(-3.8f, -0.8f)), transform.rotation);
            spawnD2++;
        }
        while (spawnR2 < data.Or_Ran2)
        {
            Instantiate(organik[2], new Vector2(Random.Range(-7f, -3.5f), Random.Range(-3.8f, -0.8f)), transform.rotation);
            spawnR2++;
        }
    }
}
