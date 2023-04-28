using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Casting : MonoBehaviour
{
    public Transform bulletPos;
    public GameObject bullet;
    public Animator anim;
    AudioSource audioSource;
    void Start() 
    {
        audioSource = GetComponent<AudioSource>();    
    }
    public void whenButtonCLicked()
    {
        anim.SetBool("Start", false);
        anim.SetTrigger("Cast");
        GameObject obj = Instantiate(bullet, bulletPos.position, bulletPos.rotation);
        audioSource.Play();
        obj.SetActive(true);
        anim.SetBool("Start", true);
    }
}
