using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class PlayerScript : MonoBehaviour
{
    [SerializeField] GameSettingScript setting;
    [SerializeField] GameSettingScript damage;
    [SerializeField] GameObject bonusTime;
    public int jumpSpeed;
    private bool isGrounded;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask WhatIsGround;
    public int KillObjectForBonus = 10;
    
    Rigidbody2D rb;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(setting.enemyKillCount == KillObjectForBonus) {
            bonusTime.SetActive(true);
        }

        if(setting.playerHealth <= 0)
        {

        }
    }
    public void Jump() 
    {
        if(isGrounded == true)
        {
            rb = GetComponent<Rigidbody2D>();
            rb.velocity = Vector2.up * jumpSpeed;
        }
        
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("FireBall") && gameObject.CompareTag("Player")) 
        {
            setting.playerHealth = setting.playerHealth-(damage.allDamage / 2);
        }
        else if(other.CompareTag("WaterBall") && gameObject.CompareTag("Player")) 
        {
            setting.playerHealth = setting.playerHealth-(damage.allDamage / 2);
        }
        else if(other.CompareTag("WoodBall") && gameObject.CompareTag("Player")) 
        {
            setting.playerHealth = setting.playerHealth-(damage.allDamage / 2);
        }
    }
    private void FixedUpdate() 
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, WhatIsGround);
    }
}
