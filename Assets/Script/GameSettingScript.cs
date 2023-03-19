using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSettingScript : MonoBehaviour
{
    [SerializeField] GameObject gameOverScene;
    [SerializeField] GameObject mainCanvas;
    [SerializeField] GameObject enemySpawn;
    public int allDamage;
    public int Score;
    public int enemyScore;
    public int enemySpeed;
    public int playerHealth;
    public int enemyAmount;
    public int gameLevel;
    public int enemyHealth;
    public int bonusTimeChoice;
    public bool isPress = false;
    public int enemyKillCount;
    public bool isSpawn;

    void Update()
    {
        if(playerHealth <= 0) {
            playerHealth = 0;
            isSpawn = true;
            enemySpawn.SetActive(false);
            gameOverScene.SetActive(true);
            mainCanvas.SetActive(false);
        }
            
    }
}
