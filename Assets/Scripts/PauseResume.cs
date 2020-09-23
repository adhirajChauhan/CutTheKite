using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PauseResume : MonoBehaviour
{
    public GameObject PauseScreen;
    public GameObject PauseButton;

    bool GamePaused;

    void Start()
    {
        GamePaused = false;
    }

    void Update()
    {
        if (GamePaused)
            Time.timeScale = 0;
        else
            Time.timeScale = 1;
    }

    //Pause game - make pause screen active and pause button inactive
    public void PauseGame()
    {
        GamePaused = true;
        PauseScreen.SetActive(true);
        PauseButton.SetActive(false);
    }

    //Resume Game - make pause screen inactive and pause button active
    public void ResumeGame()
    {
        GamePaused = false;
        PauseScreen.SetActive(false);
        PauseButton.SetActive(true);

    }
}

