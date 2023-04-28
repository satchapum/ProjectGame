using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSettingScript : MonoBehaviour
{
    [SerializeField] GameObject gameOverScene;
    [SerializeField] GameObject mainCanvas;
    [SerializeField] GameObject enemySpawn;
    [SerializeField] private FloatSO scoreSO;
    [SerializeField] private FloatSO hpSO;
    [SerializeField] private FloatSO damageSO;
    public bool gameEnd = false;
    public float allDamage;
    public int Score;
    public int enemyScore;
    public int enemySpeed;
    public float playerHealth;
    public float maxHealth;
    public int enemyAmount;
    public int gameLevel;
    public int enemyHealth;
    public int bonusTimeChoice;
    public bool isPress = false;
    public int enemyKillCount;
    public bool isSpawn;
    void Start()
    {
        allDamage = damageSO.Value;
        playerHealth = hpSO.Value;
        maxHealth = playerHealth;
    }
    void Update()
    {
        if(playerHealth <= 0) {
            gameEnd = true;
            playerHealth = 0;
            isSpawn = true;
            enemySpawn.SetActive(false);
            gameOverScene.SetActive(true);
            mainCanvas.SetActive(false);
            if(scoreSO.Value < Score)
            {
                scoreSO.Value = Score;
            }
        }
    }
}
