using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : MonoBehaviour
{
    Rigidbody2D rb;
    Vector2 up = new Vector2(0, 0.2f);
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.up * 5;
    }

    // Update is called once per frame
    // void FixedUpdate()
    // {

    //     rb.AddForce(up, ForceMode2D.Impulse);
    // }

    void OnTriggerEnter2D(Collider2D other){
        if(other.tag == "Wall"){
            Destroy(this.gameObject);
        }
    }
}
