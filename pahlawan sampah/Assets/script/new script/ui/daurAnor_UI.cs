using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class daurAnor_UI : MonoBehaviour
{
    public GameObject pilihProduk, modProduk, modPot, modHiasanKertas, modKotakTisu;
    public void onBotol()
    {
        gameObject.GetComponent<daurAnorganik>().panggil = "botol 2";
        gameObject.GetComponent<daurAnorganik>().clicked = true;
    }

    public void onKertas()
    {
        gameObject.GetComponent<daurAnorganik>().panggil = "kertas";
        gameObject.GetComponent<daurAnorganik>().clicked = true;
    }
    public void onKotak()
    {
        gameObject.GetComponent<daurAnorganik>().panggil = "kotak";
        gameObject.GetComponent<daurAnorganik>().clicked = true;
    }
    public void onKotakMakan()
    {
        gameObject.GetComponent<daurAnorganik>().panggil = "kotak makan";
        gameObject.GetComponent<daurAnorganik>().clicked = true;
    }

    public void onGunting()
    {
        gameObject.GetComponent<daurAnorganik>().spawnAlat(0);
        gameObject.GetComponent<daurAnorganik>().gunting++;
    }

    public void onKertasOrigami()
    {
        gameObject.GetComponent<daurAnorganik>().spawnAlat(1);
        gameObject.GetComponent<daurAnorganik>().origami++;
    }

    public void onLakban()
    {
        gameObject.GetComponent<daurAnorganik>().spawnAlat(2);
        gameObject.GetComponent<daurAnorganik>().lakban++;
    }

    public void onLem()
    {
        gameObject.GetComponent<daurAnorganik>().spawnAlat(3);
        gameObject.GetComponent<daurAnorganik>().lem++;
    }

    //panel//

    public void openPilihProduk()
    {
        pilihProduk.SetActive(true);
    }
    public void closePilihProduk()
    {
        pilihProduk.SetActive(false);
    }

    public void openModPot()
    {
        modPot.SetActive(true);
    }
    public void closeModPot()
    {
        modPot.SetActive(false);
        //UnityEngine.SceneManagement.SceneManager.LoadScene(Application.loadedLevel);
    }

    public void openModProduk()
    {
        modProduk.SetActive(true);
    }
    public void closeModProduk()
    {
        modProduk.SetActive(false);
        UnityEngine.SceneManagement.SceneManager.LoadScene(Application.loadedLevel);
    }

    public void openModHiasanKertas()
    {
        modHiasanKertas.SetActive(true);
    }
    public void closeModHiasanKertas()
    {
        modHiasanKertas.SetActive(false);
        UnityEngine.SceneManagement.SceneManager.LoadScene(Application.loadedLevel);
    }

    public void openModKotakTisu()
    {
        modKotakTisu.SetActive(true);
    }
    public void closeModKotakTisu()
    {
        modKotakTisu.SetActive(false);
        UnityEngine.SceneManagement.SceneManager.LoadScene(Application.loadedLevel);
    }
}
