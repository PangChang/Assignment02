using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedChange : MonoBehaviour
{
    public Slider slider;
    public Text sliderText;

    // Update is called once per frame
    void Update()
    {
        sliderText.text = slider.value.ToString();
    }
}
