using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBg : MonoBehaviour
{
    [SerializeField] GameSettingScript setting;
    //public BoxCollider2D collider;
    public Rigidbody2D rb;

    public float width;
    public float scrollSpeed;
    // Start is called before the first frame update
    void Start()
    {
        //collider = GetComponent<BoxCollider2D>();
        rb = GetComponent<Rigidbody2D>();
        //collider.enabled = false;
        if(setting.gameEnd == false)
        {
            rb.velocity = new Vector2(-scrollSpeed, 0);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < width) 
        {
            transform.position = new Vector3(-width-0.2f, transform.position.y);

        }
    }
}
