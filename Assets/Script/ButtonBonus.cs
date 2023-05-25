using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonBonus : MonoBehaviour
{
    [SerializeField] GameSettingScript setting;
    public string buttonType;
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
