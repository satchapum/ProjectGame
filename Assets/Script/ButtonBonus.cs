using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonBonus : MonoBehaviour
{
    [SerializeField] GameSettingScript setting;
    public string buttonType;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void whenButtonClicked()
    {
        while(setting.isPress == false) {
            if(buttonType == "Fire") {
                setting.bonusTimeChoice = 1;
                setting.isPress = true;
            }
            else if(buttonType == "Water") {
                setting.bonusTimeChoice = 2;
                setting.isPress = true;
            }
            else if(buttonType == "Wood") {
                setting.bonusTimeChoice = 3;
                setting.isPress = true;
            
            }
        }
        
    }
}
