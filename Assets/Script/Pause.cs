using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject mainCanvas;
    // Start is called before the first frame update
    public void PauseGame()
    {
        pauseMenu.SetActive(true);
        mainCanvas.SetActive(false);
        Time.timeScale = 0f;
    }
    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        mainCanvas.SetActive(true);
        Time.timeScale = 1f;
    }

}
