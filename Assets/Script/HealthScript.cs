using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class HealthScript : MonoBehaviour
{
    [SerializeField] GameSettingScript setting;
    [SerializeField] TextMeshProUGUI healtStatus;
    void Start()
    {
        
    }
    
    void Update()
    {
        healtStatus.text = "HP : " + setting.playerHealth.ToString();
    }
}
