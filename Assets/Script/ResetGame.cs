using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetGame : MonoBehaviour
{
    
    [SerializeField] GameObject menuButton;
    [SerializeField] GameSettingScript setting;
    public PlayerPrefsSave saveAndLoad;
    public void Reset() {
        saveAndLoad.Savedata();
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
    
}
