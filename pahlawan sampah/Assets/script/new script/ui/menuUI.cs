using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menuUI : MonoBehaviour
{
    public GameObject level;
    public GameObject caraMain;
    public GameObject credits;
    int pages;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void openCaraMain()
    {
        caraMain.SetActive(true);
    }
    public void closeCaraMain()
    {
        caraMain.SetActive(false);
    }
    public void onArea1()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("pungut");
    }
    public void openLevel()
    {
        level.SetActive(true);
    }
    public void closeLevel()
    {
        level.SetActive(false);
    }
    public void openCredits()
    {
        credits.SetActive(true);
    }
    public void closeCredits()
    {
        credits.SetActive(false);
    }
}
