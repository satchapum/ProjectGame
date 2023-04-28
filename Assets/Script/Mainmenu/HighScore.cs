using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class HighScore : MonoBehaviour
{
    [SerializeField] private FloatSO scoreSO;
    [SerializeField] TextMeshProUGUI scoreUi;

    void Update()
    {
        scoreUi.text = "High Score : " + scoreSO.Value.ToString();
    }
}
