using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject modCaraMain;
    public GameObject modFinish;

    // Start is called before the first frame update
    void Start()
    {
        //modCaraMain.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void onCaraMain_menu()
    {
        modCaraMain.SetActive(true);
    }
    public void onCloseGuide_pupuk()
    {
        modCaraMain.SetActive(false);
    }
    public void onFinish_pupuk()
    {
        modFinish.SetActive(true);
    }
}
