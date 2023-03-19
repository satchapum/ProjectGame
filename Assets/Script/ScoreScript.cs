using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScoreScript : MonoBehaviour
{
    [SerializeField] GameSettingScript score;
    [SerializeField] TextMeshProUGUI scoreUi;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreUi.text = "Score : " + score.Score.ToString();
    }
}
