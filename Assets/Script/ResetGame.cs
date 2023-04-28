using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetGame : MonoBehaviour
{
    [SerializeField] GameObject menuButton;
    [SerializeField] GameSettingScript setting;
    [SerializeField] private FloatSO coinSO;
    public void Reset() {
        coinSO.Value += setting.enemyKillCount;
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    
}
