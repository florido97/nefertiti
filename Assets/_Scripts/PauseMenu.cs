﻿using UnityEngine;
using System.Collections;

public class PauseMenu : MonoBehaviour
{

    public string mainMenu;
    public string levelSelect;

    public bool isPaused;

    public GameObject pauseMenuCanvas;


    void Update()
    {
        if (isPaused)
        {
            pauseMenuCanvas.SetActive(true);
            Time.timeScale = 0f;
        }
        else
        {
            pauseMenuCanvas.SetActive(false);
            Time.timeScale = 1f;
        }
        if (Input.GetButtonDown("Cancel"))
        {
            isPaused = !isPaused;
        }
    }

    public void Resume()
    {
        isPaused = false;
    }
    public void LevelSelect()
    {
        Application.LoadLevel(levelSelect);
    }
    public void Quit()
    {
        Application.LoadLevel(mainMenu);
    }
}
