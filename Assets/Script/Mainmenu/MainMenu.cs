using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public PlayerPrefsSave saveAndLoad;
    public GameObject mainMenu;
    public GameObject setting;
    public GameObject shop;
    void Awake() 
    {
        if(PlayerPrefs.GetFloat("damage") == 0)
        {
            PlayerPrefs.SetFloat("damage", 10);
            PlayerPrefs.SetFloat("health", 100);
            PlayerPrefs.SetFloat("lvHealth", 1);
            PlayerPrefs.SetFloat("lvDamage", 1);
            PlayerPrefs.SetFloat("coin", 0);
            PlayerPrefs.SetFloat("scoreReal", 0);
        }
        saveAndLoad.LoadData();
    }
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
        saveAndLoad.Savedata();
        mainMenu.SetActive(true);
        setting.SetActive(false);
        shop.SetActive(false);
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
