using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class produksi : MonoBehaviour
{
    public bool pot, hiasKertas, kotTisu;
    public GameObject modPot, modHiasKertas, modKotTisu, modProduk;
    int bot2, ker, kot, kotMak;
    int pot_, hiasKertas_, kotTisu_;
    public Text potTxt, HiasKertasTxt, KotTisuTxt;

    public GameObject mainCamera;
    // Start is called before the first frame update
    void Start()
    {
        pot_ = 0; hiasKertas_ = 0; kotTisu_ = 0;
        pot = false; hiasKertas = false; kotTisu = false;
    }

    // Update is called once per frame
    void Update()
    {
        bot2 = gameObject.GetComponent<daurAnorganik>().bot2Count;
        ker = gameObject.GetComponent<daurAnorganik>().kertasCount;
        kot = gameObject.GetComponent<daurAnorganik>().KotakCount;
        kotMak = gameObject.GetComponent<daurAnorganik>().kotakMakanCount;
    }

    public void pilihPot()
    {
        pot = true;
        hiasKertas = false;
        kotTisu = false;
        modProduk.SetActive(false);
    }
    public void pilihKotakHias()
    {
        pot = false;
        hiasKertas = true;
        kotTisu = false;
        modProduk.SetActive(false);
    }
    public void pilihKotakTisu()
    {
        pot = false;
        hiasKertas = false;
        kotTisu = true;
        modProduk.SetActive(false);
    }

    public void hasil(string nama)
    {
        if (nama == "pot")
        {
            potTxt.text = pot_.ToString() + " POT TELAH DIBUAT";
            modPot.SetActive(true);
            modHiasKertas.SetActive(false);
            modKotTisu.SetActive(false);
        }
        if (nama == "hiasan kertas")
        {
            HiasKertasTxt.text = hiasKertas_.ToString() + " HIASAN KERTAS TELAH DIBUAT";
            modPot.SetActive(false);
            modHiasKertas.SetActive(true);
            modKotTisu.SetActive(false);
        }
        if (nama == "kotak tisu")
        {
            KotTisuTxt.text = kotTisu_.ToString() + " KOTAK TISU TELAH DIBUAT";
            modPot.SetActive(false);
            modHiasKertas.SetActive(false);
            modKotTisu.SetActive(true);
        }
    }
    public void pilihProdukClick()
    {
        modProduk.SetActive(false);
    }
    public void produksiStart()
    {
        if (pot)
        {
            if (gameObject.GetComponent<daurAnorganik>().gunting >= 1 && bot2 >= 1)
            {
                pot_++;
                gameObject.GetComponent<daurAnorganik>().bot2Count--;
            }
            else
            {
                data.uang += 2000;
                data.pot += pot_;
                hasil("pot");
            }
        }
        if (hiasKertas)
        {
            if (gameObject.GetComponent<daurAnorganik>().gunting >= 1 &&
                gameObject.GetComponent<daurAnorganik>().lem >= 1 && ker >= 2)
            {
                hiasKertas_++;
                gameObject.GetComponent<daurAnorganik>().kertasCount-=2;
            }
            else
            {
                data.uang += 4000;
                data.pot += pot_;
                hasil("hiasan kertas");
            }
        }
        if (kotTisu)
        {
            if (gameObject.GetComponent<daurAnorganik>().gunting >= 1 &&
                gameObject.GetComponent<daurAnorganik>().lakban >= 1 && kotMak >= 2)
            {
                kotTisu_++;
                gameObject.GetComponent<daurAnorganik>().kotakMakanCount-=2;
            }
            else
            {
                data.uang += 3000;
                data.KotTisu += kotTisu_;
                hasil("kotak tisu");
            }
        }
    }
}
