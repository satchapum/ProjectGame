using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class EnemyInfo : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameSettingScript setting;
    [SerializeField] TextMeshProUGUI healtStatus;
    void Update()
    {
        healtStatus.text = "Enemy Healt : " + setting.enemyHealth.ToString();
    }
}
