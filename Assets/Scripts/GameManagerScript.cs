using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{
    public bool GamePaused = false;
    public GameObject pausemenuUI;
    public GameObject controlsUI;

    public void restart()
    {
        SceneManager.LoadScene("Level1"); //Restart button loads the main scene
        Time.timeScale = 1f;
    }

    public void mainMenu()
    {
        SceneManager.LoadScene("MainMenu"); //Main Menu button loads Main Menu
    }

    public void quit()
    {
        Application.Quit(); //Quit button quits the application but doesn't work in editor
    }

    public void howToPlay()
    {
        SceneManager.LoadScene("Controls"); //How to Play button loads controls and game objective
    }

    public void bonusLevel()
    {
        SceneManager.LoadScene("BonusLevel"); 
    }



    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GamePaused)
            {
                resume();
                controlsUI.SetActive(false);
            }
            else
            {
                pause();
            }
        }

    }

   public void resume()
    {
        pausemenuUI.SetActive(false);
        Time.timeScale = 1f;
        GamePaused = false;
    }

   public void pause()
    {
        pausemenuUI.SetActive(true);
        Time.timeScale = 0f;
        GamePaused = true;
    }
}


