using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvaderBlockController : MonoBehaviour
{
    
    void OnTriggerEnter2D(Collider2D other){
        if(other.tag == "Projectile"){
            GetComponent<Collider2D>().enabled = false;
            InvaderBlockManager.instance.BlockDestroyed();
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
        if(other.tag == "Player"){
            if(InvaderGameManager.instance.gameEnded == false){
                InvaderGameManager.instance.GameOver();
            }
            
        }
    }

}
