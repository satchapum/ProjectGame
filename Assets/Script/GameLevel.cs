using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLevel : MonoBehaviour
{
    [SerializeField] GameSettingScript setting;
    public int ScoreTarget;
    void Update()
    {
        if(setting.Score >= ScoreTarget) {
            setting.enemyHealth += 20;
            setting.enemyScore *= 2;
            ScoreTarget *= 2;
        }
    }
}
