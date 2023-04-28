using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject setting;
    public GameObject shop;
    public void Setting()
    {
        mainMenu.SetActive(false);
        setting.SetActive(true);
    }
    public void Shop()
    {
        mainMenu.SetActive(false);
        shop.SetActive(true);
    }
    public void BackToMainMenu()
    {
        mainMenu.SetActive(true);
        setting.SetActive(false);
        shop.SetActive(false);
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
