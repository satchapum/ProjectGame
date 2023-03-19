using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] PlayerScript playerInfo;
    // Start is called before the first frame update
    public void whenButtonCLicked()
    {
        playerInfo.Jump();
    }
}
