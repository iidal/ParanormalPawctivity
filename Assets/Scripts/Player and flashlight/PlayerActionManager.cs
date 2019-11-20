using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActionManager : MonoBehaviour
{

  
    public ItemManager currentHighlightedItem; //item in flashlight area

    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.tag == "Item"){
            currentHighlightedItem = other.gameObject.GetComponent<ItemManager>();
            PlayerManager.instance.currentItem = currentHighlightedItem;
            Debug.Log("item found");
        }
    }
    void OnTriggerExit2D(Collider2D other){
         if(other.gameObject.tag == "Item"){
            currentHighlightedItem = null;
            PlayerManager.instance.currentItem = null;
            Debug.Log("item ignored");
        }
    }

}
