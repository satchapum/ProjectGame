using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // [SerializeField] private FloatSO damageSO;
    // [SerializeField] private FloatSO healthSO;
    // [SerializeField] private FloatSO lvHealthSO;
    // [SerializeField] private FloatSO lvDamageSO;
    // [SerializeField] private FloatSO coinSO;
    // [SerializeField] private FloatSO CurrentCoinUseHpSO;
    // [SerializeField] private FloatSO CurrentCoinUseDamageSO;
    // [SerializeField] private FloatSO score;
    //public GameData gameData;
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
    // public void SaveGame()
    // {
    //     gameData = new GameData();
    //     gameData.damage = damageSO.Value;
    //     gameData.health = healthSO.Value;
    //     gameData.lvHealth = lvHealthSO.Value;
    //     gameData.lvDamage = lvDamageSO.Value;
    //     gameData.coin = coinSO.Value;
    //     gameData.currentCoinUseHp = CurrentCoinUseHpSO.Value;
    //     gameData.currentCoinUseDamage = CurrentCoinUseDamageSO.Value;
    //     gameData.scoreReal = score.Value;
    //     SaveManager.Save(gameData, "MySaveFile");
    // }

    // public void LoadGame()
    // {
    //     gameData = new GameData(); 
    //     SaveManager.Load("MySaveFile");
    //     damageSO.Value = gameData.damage;
    //     healthSO.Value = gameData.health;
    //     lvHealthSO.Value = gameData.lvHealth;
    //     lvDamageSO.Value = gameData.lvDamage;
    //     coinSO.Value = gameData.coin;
    //     CurrentCoinUseHpSO.Value = gameData.currentCoinUseHp;
    //     CurrentCoinUseDamageSO.Value = gameData.currentCoinUseDamage;
    //     score.Value = gameData.scoreReal;
    //     SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    // }
}
