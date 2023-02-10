using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallColor : MonoBehaviour
{
    public Dropdown ColorDropdown;
    public Text ColorText;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player.GetComponent<Renderer>().material.color = Color.white;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ChooseColor() // use in the change event for the dropdown
    {
        switch (ColorDropdown.value)
        {
            case 1:
                ColorText.text = ColorDropdown.options[1].text;
                player.GetComponent<Renderer>().material.color = Color.red;
                break;
            case 2:
                ColorText.text = ColorDropdown.options[2].text;
                player.GetComponent<Renderer>().material.color = Color.green;
                break;
            case 3:
                ColorText.text = ColorDropdown.options[3].text;
                player.GetComponent<Renderer>().material.color = Color.blue;
                break;
            default:
                ColorText.text = ColorDropdown.options[0].text;
                player.GetComponent<Renderer>().material.color = Color.white;
                break;
        }
    }
}