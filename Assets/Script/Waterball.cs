using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waterball : MonoBehaviour
{
    public Transform bulletPos;
    public GameObject bullet;
    public Animator anim;
    public void whenButtonCLicked()
    {
        anim.SetBool("Start", false);
        anim.SetTrigger("Cast");
        GameObject obj = Instantiate(bullet, bulletPos.position, bulletPos.rotation);
        obj.SetActive(true);
        anim.SetBool("Start", true);
    }
}
