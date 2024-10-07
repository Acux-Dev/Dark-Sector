using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    public static bool GameIsPaused = false;

    public GameObject PauseMenuUI;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("escape oprimido");
            if (GameIsPaused)
            {
                Resume();
            } else
            {
                Time.timeScale = 0f;
                PauseMenuUI.SetActive(true);
                GameIsPaused = true;
                AudioListener.volume = 0f;
            }
        }
    }

    public void Resume()
    {
        Time.timeScale = 1f;
        PauseMenuUI.SetActive(false);
        GameIsPaused = false;
        AudioListener.volume = 1f;
    }

    public void Exit()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main Menu");
        GameIsPaused = false;
        AudioListener.volume = 1f;
    }
}
