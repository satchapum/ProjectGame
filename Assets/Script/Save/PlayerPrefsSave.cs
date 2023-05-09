using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerPrefsSave : MonoBehaviour
{
    [SerializeField]public FloatSO damageSO;
    public FloatSO healthSO;
    public FloatSO lvHealthSO;
    public FloatSO lvDamageSO;
    public FloatSO coinSO;
    public FloatSO score;

    public float damage;
    public float health;
    public float lvHealth;
    public float lvDamage;
    public float coin;
    public float scoreReal ;
    
    public void Update()
    {
        damage = damageSO.Value;
        health = healthSO.Value;
        lvHealth = lvHealthSO.Value;
        lvDamage = lvDamageSO.Value;
        coin = coinSO.Value;
        scoreReal = score.Value;
    }
    public void Savedata()
    {
        PlayerPrefs.SetFloat("damage", damage);
        PlayerPrefs.SetFloat("health", health);
        PlayerPrefs.SetFloat("lvHealth", lvHealth);
        PlayerPrefs.SetFloat("lvDamage", lvDamage);
        PlayerPrefs.SetFloat("coin", coin);
        PlayerPrefs.SetFloat("scoreReal", scoreReal);

        LoadData();
        Debug.Log(damage);
        Debug.Log(health);
        Debug.Log(lvHealth);
        Debug.Log(lvDamage);
        Debug.Log(coin);
        Debug.Log(scoreReal);
        
    }
    public void LoadData()
    {
        damage = PlayerPrefs.GetFloat("damage");
        health = PlayerPrefs.GetFloat("health");
        lvHealth = PlayerPrefs.GetFloat("lvHealth");
        lvDamage = PlayerPrefs.GetFloat("lvDamage");
        coin = PlayerPrefs.GetFloat("coin");
        scoreReal = PlayerPrefs.GetFloat("scoreReal");

        damageSO.Value = damage;
        healthSO.Value = health;
        lvHealthSO.Value = lvHealth;
        lvDamageSO.Value = lvDamage;
        coinSO.Value = coin;
        score.Value = scoreReal;
    }
    public void ResetGame()
    {
        PlayerPrefs.SetFloat("damage", 10);
        PlayerPrefs.SetFloat("health", 100);
        PlayerPrefs.SetFloat("lvHealth", 1);
        PlayerPrefs.SetFloat("lvDamage", 1);
        PlayerPrefs.SetFloat("coin", 0);
        PlayerPrefs.SetFloat("scoreReal", 0);

        damage = PlayerPrefs.GetFloat("damage");
        health = PlayerPrefs.GetFloat("health");
        lvHealth = PlayerPrefs.GetFloat("lvHealth");
        lvDamage = PlayerPrefs.GetFloat("lvDamage");
        coin = PlayerPrefs.GetFloat("coin");
        scoreReal = PlayerPrefs.GetFloat("scoreReal");

        damageSO.Value = damage;
        healthSO.Value = health;
        lvHealthSO.Value = lvHealth;
        lvDamageSO.Value = lvDamage;
        coinSO.Value = coin;
        score.Value = scoreReal;

        SceneManager.LoadScene(0);
    }
}
