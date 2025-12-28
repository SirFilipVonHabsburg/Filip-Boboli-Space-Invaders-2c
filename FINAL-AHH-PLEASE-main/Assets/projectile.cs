using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class projectile : MonoBehaviour
{

    public float movespeed;
    private Vector2 moveSpeed;
    public static projectile instance;

    public object Vectosr2 { get; private set; }


    public Rigidbody2D rb;
    
    // Start is called before the first frame update
    void Start()
    {
        rb.AddForce(Vector2.up * movespeed, ForceMode2D.Impulse);
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * moveSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }


}   }
