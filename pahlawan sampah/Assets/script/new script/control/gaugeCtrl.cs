using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gaugeCtrl : MonoBehaviour
{
    public Text gaugeTxt;
    bool upDown;
    bool slideStop;
    bool gaugeDone;
    float progress = 0;
    public Slider slider;
    public float speed;

    private void Start()
    {
        Debug.Log("start");
        slideStop = true;
        gaugeDone = false;
    }

    private void Update()
    {
        if (slider.value == slider.minValue)
        {
            upDown = true;
        }
        if (slider.value == slider.maxValue)
        {
            upDown = false;
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            if (!gaugeDone)
            {
                slideStop = false;
                gaugeDone = true;
            }
            else
            {
                slideStop = true;
                data.nilaiPupuk = slider.value;
            }
        }
        if (!slideStop)
        {
            if (slider.value == slider.minValue)
            {
                upDown = true;
            }
            if (slider.value == slider.maxValue)
            {
                upDown = false;
            }
            sliderMove();
        }
    }

    public void onSliderChanged(float value)
    {
        gaugeTxt.text = value.ToString()+" hari";
    }

    void sliderUp()
    {
        progress += speed * Time.deltaTime;
        slider.value = progress;
    }

    void sliderDown()
    {
        progress -= speed * Time.deltaTime;
        slider.value = progress;
    }

    void sliderMove()
    {
        if (!upDown)
        {
            sliderDown();
        }
        else
        {
            sliderUp();
        }
    }


}
