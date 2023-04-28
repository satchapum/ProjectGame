using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScoreScript : MonoBehaviour
{
    [SerializeField] GameSettingScript score;
    [SerializeField] TextMeshProUGUI scoreUi;

    void Update()
    {
        scoreUi.text = "Score : " + score.Score.ToString();
    }
}
