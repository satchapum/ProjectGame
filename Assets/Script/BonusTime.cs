using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusTime : MonoBehaviour
{
    [SerializeField] GameObject fireButton;
    [SerializeField] GameObject waterButton;
    [SerializeField] GameObject woodButton;
    [SerializeField] GameObject fireButtonBonus;
    [SerializeField] GameObject waterButtonBonus;
    [SerializeField] GameObject woodButtonBonus;
    [SerializeField] GameObject spawnScript;
    [SerializeField] GameSettingScript setting;
    [SerializeField] PlayerScript firstScore;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(setting.enemyKillCount >= firstScore.KillObjectForBonus) {
            TurnOnBonus();
            if(setting.isPress == true) {
                OnBonusTime();
            }
        }
    }

    void TurnOnBonus()
    {
        setting.isSpawn = true;
        spawnScript.SetActive(false);
        fireButton.SetActive(false);
        waterButton.SetActive(false);
        woodButton.SetActive(false);
        fireButtonBonus.SetActive(true);
        waterButtonBonus.SetActive(true);
        woodButtonBonus.SetActive(true);
    }
    void TurnOffBonus()
    {
        setting.isSpawn = false;
        spawnScript.SetActive(true);
        fireButton.SetActive(true);
        waterButton.SetActive(true);
        woodButton.SetActive(true);
        fireButtonBonus.SetActive(false);
        waterButtonBonus.SetActive(false);
        woodButtonBonus.SetActive(false);
    }
    void OnBonusTime() {
        int numberType = Random.Range(1,3);
        if(setting.bonusTimeChoice == 1 && setting.isSpawn == true) {
            if(numberType == 1) {
                setting.Score += setting.enemyScore * 2; 
                setting.bonusTimeChoice = 0;
                setting.isPress = false;
                
            }
            else {
                firstScore.KillObjectForBonus *= 2;
                TurnOffBonus();
                setting.isPress = false;
                gameObject.SetActive(false);
            }
        }
        else if(setting.bonusTimeChoice == 2 && setting.isSpawn == true) {
            if(numberType == 2) {
                setting.Score += setting.enemyScore * 2;
                setting.bonusTimeChoice = 0;
                setting.isPress = false;
            }
            else {
                TurnOffBonus();
                firstScore.KillObjectForBonus *= 2;
                setting.isPress = false;
                gameObject.SetActive(false);
            }
        }
        else if(setting.bonusTimeChoice == 3 && setting.isSpawn == true) {
            if(numberType == 3) {
                setting.Score += setting.enemyScore * 2;
                setting.bonusTimeChoice = 0;
                setting.isPress = false;
            }
            else {
                TurnOffBonus();
                firstScore.KillObjectForBonus *= 2;
                setting.isPress = false;
                gameObject.SetActive(false);
            }
        }
    }
}
