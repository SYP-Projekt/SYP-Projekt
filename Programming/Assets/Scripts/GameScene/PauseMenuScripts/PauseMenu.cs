using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool gameIsPaused = false;
    public static bool gameIsInOptions = false;
    public static bool isAtInventory = false;

    public GameObject pauseMenuUI;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Escape))
        {
            if(gameIsPaused)
            {
                Resume();
            } else
            {
                if (!isAtInventory)
                {
                    Pause();
                }
            }
        }
    }
    public void Resume()
    {
        Cursor.lockState = CursorLockMode.Locked;
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused = false;
        Debug.Log("Resumed");
    }
    public void Pause()
    {
        Cursor.lockState = CursorLockMode.None;
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;
        Debug.Log("Paused");
    }
    public void LoadMenu()
    {
        SceneManager.LoadScene("Options");
        Debug.Log("Loading Menu...");
    }
    public void QuitGame()
    {
        Debug.Log("Quiting Game...");
        Time.timeScale =  0.5f;
        SceneManager.LoadScene("Menu");
    }
}
