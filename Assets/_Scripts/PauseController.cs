using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseController : MonoBehaviour {

    public static bool isPaused = false;
    public GameObject pauseMenuUI;
    public GameObject winMenuUI;
    private bool activeWin;


    private void Awake()
    {
        activeWin = false;
    }

    // Update is called once per frame
    void Update () {

        if(winMenuUI.activeInHierarchy == true)
        {
            GameWon();
        }

        if (Input.GetKeyDown(KeyCode.Escape) && activeWin == false)
        {
                if (isPaused)
                {
                    Resume();
                }
                else
                {
                    Pause();
                }
        }
	}

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }


   public void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

    public void GameWon()
    {
        activeWin = true;
    }
}
