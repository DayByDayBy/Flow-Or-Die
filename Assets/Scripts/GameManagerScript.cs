using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{
  

    public void restart()
    {
        SceneManager.LoadScene("Joshua"); //Restart button loads the main scene
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

  
}


