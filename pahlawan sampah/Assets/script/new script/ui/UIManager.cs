using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject modCaraMain;

    // Start is called before the first frame update
    void Start()
    {
        modCaraMain.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void onCaraMain()
    {
        modCaraMain.SetActive(true);
    }
}
