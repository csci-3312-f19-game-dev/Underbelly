using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //public GameManager gameManager;

    //Takes the Player to SideA
    public void PlayGame ()
    {
        SceneManager.LoadScene("Spawn");
    }

    //Closes Application
    public void QuitGame ()
    {
        Application.Quit();
    }

    //Takes the Player to the Controls and About Page
    public void LoadControls ()
    {
        SceneManager.LoadScene("Controls");
    }

    //Takes the Player Back to the Main Menu
    public void Back ()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
