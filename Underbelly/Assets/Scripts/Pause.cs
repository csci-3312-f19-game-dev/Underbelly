using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public GameObject PauseMenu, PauseButton;

    public void PauseGame() {
        PauseMenu.SetActive(true);
        PauseButton.SetActive(false);
        Time.timeScale = 0;
    }

    public void ResumeGame() {
        PauseMenu.SetActive(false);
        PauseButton.SetActive(true);
        Time.timeScale = 0;
    }
}
