using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinGame : MonoBehaviour {

    public bool youWin;
    public GameObject winMenuUI;

    private void Awake()
    {
        Time.timeScale = 1f;
        youWin = false;
        winMenuUI.SetActive(false);
    }

    private void Update()
    {
        if (youWin)
        {
            WinMenu();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        youWin = true;
        
    }

    public void WinMenu()
    {
        winMenuUI.SetActive(true);
        Time.timeScale = 0f;
    }

    public void LevelSelect()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }

    public void NextLevel()
    {

        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        SceneManager.LoadScene(nextSceneIndex);
    }
}
