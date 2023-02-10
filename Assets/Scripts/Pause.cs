using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Pause : MonoBehaviour
{
    public Text timeText;
    public Button resumeButton;
    private bool isPaused = false;


    // Start is called before the first frame update
    void Start() 
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) // ESC key pauses AND resumes
        {
            if (isPaused)
            {
                ResumeGame(); //when paused, it will resume gameplay
            }
            else
            {
                PauseGame();
            }
        }
    }
    void PauseGame()
    {
        Time.timeScale = 0;
        isPaused = true;
        timeText.text = "Game is paused";
        resumeButton.gameObject.SetActive(true);
    }
    public void ResumeGame() // called from ESC; also attached to the resume button
    {
        Time.timeScale = 1;
        isPaused = false;
        timeText.text = "Time: " + DateTime.Now.ToString();
        resumeButton.gameObject.SetActive(false); // hide the Resume button while playing
    }

}
