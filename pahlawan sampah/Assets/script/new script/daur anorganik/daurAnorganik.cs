using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class daurAnorganik : MonoBehaviour
{
    public GameObject[] sampah;
    public GameObject[] alat;
    public Transform a1, a2, b1, b2;
    public string panggil;
    public bool clicked = false;
    bool spawned;
    public GameObject pilihProduk;
    public Text racikan;

    public int bot2Count;
    public int kertasCount;
    public int KotakCount;
    public int kotakMakanCount;

    public int gunting, lakban, lem, origami;

    //int index;

    // Start is called before the first frame update
    void pot()
    {
        racikan.text = "POT\nMASUKAN GUNTING + BOTOL (1)";
    }
    void hiasanKertas()
    {
        racikan.text = "HIASAN KERTAS\nMASUKAN GUNTING, LEM + KERTAS (2)";
    }
    void kotakTisu()
    {
        racikan.text = "KOTAK TISU\nMASUKAN GUNTING, LAKBAN + KOTAK DUS (2)";
    }
    void Start()
    {
        Debug.Log("start");
        bot2Count = 0; kertasCount = 0; KotakCount = 0; kotakMakanCount = 0;
        //data.An_Bot2 = 1;
        //data.An_Ker = 2;
        //data.An_KotMak = 2;
        pilihProduk.SetActive(true);
    }
    
    // Update is called once per frame
    void Update()
    {
        panggilSampah();
        if (gameObject.GetComponent<produksi>().pot == true)
        {
            pot();
        }
        if(gameObject.GetComponent<produksi>().hiasKertas == true)
        {
            hiasanKertas();
        }
        if(gameObject.GetComponent<produksi>().kotTisu == true)
        {
            kotakTisu();
        }
    }

    public void spawnAlat(int index)
    {
        Instantiate(alat[index], new Vector2(a2.position.x, Random.Range(a1.position.y,a2.position.y)), transform.rotation);
    }

    void spawnSampah(int index)
    {
        Instantiate(sampah[index], new Vector2(b1.position.x, Random.Range(b1.position.y,b2.position.y)), transform.rotation);
    }

    void panggilSampah()
    {
        if (panggil == "botol 2" && clicked)
        {
            //data.An_Bot2 = 1;
            if (data.An_Bot2 != 0)
            {
                //int count = 0;
                spawnSampah(0);
                data.An_Bot2--;
                bot2Count++;
                //jumlahBot2.txt=data.An_Bot2;
            }
            clicked = !clicked;
        }
        if (panggil == "kertas" && clicked)
        {
            if (data.An_Ker != 0)
            {
                //int count = 0;
                spawnSampah(1);
                kertasCount++;
                data.An_Ker--;
                //jumlahKer.txt=data.An_Ker;
            }
            clicked = !clicked;
        }
        if (panggil == "kotak" && clicked)
        {
            if (data.An_Kot != 0)
            {
                //int count = 0;
                spawnSampah(3);
                KotakCount++;
                data.An_Kot--;
                //jumlahKot.txt=data.An_Kot;
            }
            clicked = !clicked;
        }
        if (panggil == "kotak makan" && clicked)
        {
            if (data.An_KotMak != 0)
            {
                //int count = 0;
                spawnSampah(2);
                kotakMakanCount++;
                data.An_KotMak--;
                //jumlahKotMak.txt=data.An_KotMak;
            }
            clicked = !clicked;
        }
    }
}
