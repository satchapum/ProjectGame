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
    [SerializeField] private FloatSO lvHealthSO;
    [SerializeField] private FloatSO lvDamageSO;

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
    public float lvDamage;
    public float lvHealth;
    void Start()
    {
        lvHealth = lvHealthSO.Value;
        lvDamage = lvDamageSO.Value;
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
