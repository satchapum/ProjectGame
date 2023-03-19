using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScriptWood : MonoBehaviour
{
    public int health;
    [SerializeField] GameSettingScript setting;
    public Transform bulletPos;
    public GameObject bullet;
    Rigidbody2D rb;
    void Start()
    {
        health = setting.enemyHealth;
        setting.enemyAmount += 1;
    }

    // Update is called once per frame
    void Update()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.left * setting.enemySpeed;

        if(health <= 0) 
        {
            Destroy(gameObject);
            setting.enemyKillCount++;
            setting.Score += setting.enemyScore;
            setting.enemyAmount -= 1;
        }
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("FireBall") && gameObject.CompareTag("KnightWood")) 
        {
            health = health-((setting.allDamage)*2);
        }
        else if(other.CompareTag("WaterBall") && gameObject.CompareTag("KnightWood")) 
        {
            GameObject obj = Instantiate(bullet, bulletPos.position, bulletPos.rotation);
            obj.SetActive(true);
        }
        else if(other.CompareTag("WoodBall") && gameObject.CompareTag("KnightWood")) 
        {
            health = health-((setting.allDamage)*0);
        }
        
        if(other.CompareTag("Player")) {
            setting.playerHealth -= 30;
            setting.enemyAmount -= 1;
            Destroy(gameObject);
        }
        else if(other.CompareTag("BlockPlayer")) {
            setting.enemyAmount -= 1;
            Destroy(gameObject);
        }
    }
}
