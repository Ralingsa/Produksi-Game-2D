using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneManager : MonoBehaviour
{
    public bool isEscapeToExit;

    public void mulaiPermainan()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("pungut");
    }

    public void keWarning()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("warning");
    }
    public void kemabaliKeMenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("menu");
    }

    public void retry()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(Application.loadedLevel);
    }

    public void pungut1()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("pungut1");
    }

    public void pupuk1()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("pupuk");
    }

    public void shop()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("shop");
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            if (isEscapeToExit)
            {
                Application.Quit();
            }
            else
            {
                kemabaliKeMenu();
            }
        }
    }
}
