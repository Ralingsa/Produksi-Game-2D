using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour
{
    public void openMenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("menuBaru");
    }

    public void openShop()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Shop");
    }
    public void exit()
    {
        Application.Quit();
    }
    public void stageAnor()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("anorganik");
    }
}
