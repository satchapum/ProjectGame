using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Woodball : MonoBehaviour
{
    public Transform bulletPos;
    public GameObject bullet;

    void Update()
    {
        
    }
    public void whenButtonCLicked()
    {
        GameObject obj = Instantiate(bullet, bulletPos.position, bulletPos.rotation);
        obj.SetActive(true);
    }
}
