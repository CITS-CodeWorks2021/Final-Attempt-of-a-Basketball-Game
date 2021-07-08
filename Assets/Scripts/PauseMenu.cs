using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pausemenuUI;
    public GameObject restartButtonUI;

    // Update is called once per frame

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) {

            if (GameIsPaused)
            {

                Resume();

            }
            else {

                Pause();
            
            }

        
        
        }

        
        void Pause () {

            pausemenuUI.SetActive(true);
            restartButtonUI.SetActive(false);
            Time.timeScale = 0f;
            GameIsPaused = true;
        
        }

        
 
    
    }

    public void Resume()
    {

        pausemenuUI.SetActive(false);
        restartButtonUI.SetActive(true);
        Time.timeScale = 1f;
        GameIsPaused = false;

    }

    public void LoadMenu() {

        Time.timeScale = 1f;
        Debug.Log("Loading Menu...");
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitGame() {

        Debug.Log("Quiting Game...");
        Application.Quit();
    }

    public void RestartGameButton()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void BackToLevelSelectorButton()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("GameMenu");
    }

    public void ContinueGame() {

        SceneManager.LoadScene("Level_1");
    
    }

    public void ContinueGame1()
    {

        SceneManager.LoadScene("Level_2");

    }

    public void ContinueGame2()
    {

        SceneManager.LoadScene("Level_3");

    }

    public void ContinueGame3()
    {

        SceneManager.LoadScene("Level_4");

    }

    public void ContinueGame4()
    {

        SceneManager.LoadScene("Level_5");

    }

    public void ContinueGame5()
    {

        SceneManager.LoadScene("Level_6");

    }
}
