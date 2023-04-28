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
    [SerializeField] private FloatSO CurentCoinUseHpSO;
    [SerializeField] private FloatSO CurentCoinUseDamageSO;
    [SerializeField] TextMeshProUGUI CurentCoinUseHp;
    [SerializeField] TextMeshProUGUI CurentCoinUseDamage;
    [SerializeField] TextMeshProUGUI CurentDamage;
    [SerializeField] TextMeshProUGUI CurentHealth;
    [SerializeField] TextMeshProUGUI CurentCoin;
    public void Start()
    {
        CurentCoinUseDamageSO.Value = 10 * lvDamageSO.Value;
        CurentCoinUseHpSO.Value = 10 * lvDamageSO.Value;
        CurentCoinUseHp.text = CurentCoinUseHpSO.Value.ToString();
        CurentCoinUseDamage.text = CurentCoinUseDamageSO.Value.ToString();
        CurentCoin.text = "Your coins : " + coinSO.Value.ToString();
        CurentDamage.text =  "Current Damage : " + damageSO.Value.ToString();
        CurentHealth.text =  "Current Health : " + healthSO.Value.ToString();
    }
    public void UpgradeDamage()
    {
        if(coinSO.Value >= CurentCoinUseDamageSO.Value)
        {
            coinSO.Value -= CurentCoinUseDamageSO.Value;
            damageSO.Value = 10 + (10 * lvDamageSO.Value);
            lvDamageSO.Value++;
            CurentCoinUseDamageSO.Value = 10 * lvDamageSO.Value;
            CurentCoinUseDamage.text = CurentCoinUseDamageSO.Value.ToString();
            CurentDamage.text =  "Current Damage : " + damageSO.Value.ToString();
            CurentCoin.text = "Your coins : " + coinSO.Value.ToString();
        }
        
    }
    public void UpgradeHealt()
    {
        if(coinSO.Value >= CurentCoinUseHpSO.Value)
        {
            coinSO.Value -= CurentCoinUseHpSO.Value;
            healthSO.Value = 100 + (10 * lvHealthSO.Value);
            lvHealthSO.Value++;
            CurentCoinUseHpSO.Value = 10 * lvHealthSO.Value;
            CurentCoinUseHp.text =  CurentCoinUseHpSO.Value.ToString();
            CurentHealth.text =  "Current Health : " + healthSO.Value.ToString();
            CurentCoin.text = "Your coins : " + coinSO.Value.ToString();
        }

    }
}
