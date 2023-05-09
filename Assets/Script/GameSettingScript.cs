using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSettingScript : MonoBehaviour
{
    [SerializeField] GameObject gameOverScene;
    [SerializeField] GameObject mainCanvas;
    [SerializeField] GameObject enemySpawn;
    [SerializeField] public FloatSO scoreSO;
    [SerializeField] public FloatSO hpSO;
    [SerializeField] public FloatSO damageSO;
    [SerializeField] public FloatSO lvHealthSO;
    [SerializeField] public FloatSO lvDamageSO;
    [SerializeField] public FloatSO coinSO;
    public PlayerPrefsSave saveAndLoad;

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
            playerHealth = 100;
            gameEnd = true;
            isSpawn = true;
            enemySpawn.SetActive(false);
            gameOverScene.SetActive(true);
            mainCanvas.SetActive(false);
            if(scoreSO.Value < Score)
            {
                scoreSO.Value = Score;
            }
            coinSO.Value += enemyKillCount;
        }
    }
}
