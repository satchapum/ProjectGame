using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Upgrade : MonoBehaviour
{
    [SerializeField] private FloatSO damageSO;
    [SerializeField] private FloatSO healthSO;
    [SerializeField] private FloatSO lvHealthSO;
    [SerializeField] private FloatSO lvDamageSO;
    [SerializeField] private FloatSO coinSO;
    [SerializeField] private float CurrentCoinUseHpSO;
    [SerializeField] private float CurrentCoinUseDamageSO;
    [SerializeField] TextMeshProUGUI CurrentCoinUseHp;
    [SerializeField] TextMeshProUGUI CurrentCoinUseDamage;
    [SerializeField] TextMeshProUGUI CurrentDamage;
    [SerializeField] TextMeshProUGUI CurrentHealth;
    [SerializeField] TextMeshProUGUI CurrentCoin;
    private float lvHealth;
    private float lvDamage;
    public void Awake()
    {
        lvHealth = lvHealthSO.Value;
        lvDamage = lvDamageSO.Value;
        CurrentCoinUseDamageSO = 10 * lvDamageSO.Value;
        CurrentCoinUseHpSO = 10 * lvHealthSO.Value;
        CurrentCoinUseHp.text = CurrentCoinUseHpSO.ToString();
        CurrentCoinUseDamage.text = CurrentCoinUseDamageSO.ToString();
        CurrentCoin.text = "Your coins : " + coinSO.Value.ToString();
        CurrentDamage.text =  "Current Damage : " + damageSO.Value.ToString();
        CurrentHealth.text =  "Current Health : " + healthSO.Value.ToString();
    }
    public void UpgradeDamage()
    {
        if(coinSO.Value >= CurrentCoinUseDamageSO)
        {
            coinSO.Value -= CurrentCoinUseDamageSO;
            damageSO.Value = 10 + (10 * lvDamageSO.Value);
            lvDamageSO.Value = lvDamageSO.Value + 1;
            CurrentCoinUseDamageSO = 10 * lvDamageSO.Value;
            CurrentCoinUseDamage.text = CurrentCoinUseDamageSO.ToString();
            CurrentDamage.text =  "Current Damage : " + damageSO.Value.ToString();
            CurrentCoin.text = "Your coins : " + coinSO.Value.ToString();
        }
        
    }
    public void UpgradeHealt()
    {
        if(coinSO.Value >= CurrentCoinUseHpSO)
        {
            coinSO.Value -= CurrentCoinUseHpSO;
            healthSO.Value = 100 + (10 * lvHealthSO.Value);
            lvHealthSO.Value = lvHealthSO.Value + 1;
            CurrentCoinUseHpSO = 10 * lvHealthSO.Value;
            CurrentCoinUseHp.text =  CurrentCoinUseHpSO.ToString();
            CurrentHealth.text =  "Current Health : " + healthSO.Value.ToString();
            CurrentCoin.text = "Your coins : " + coinSO.Value.ToString();
        }

    }
}
