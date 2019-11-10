using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActionManager : MonoBehaviour
{

    public ItemManager currentHighlightedItem; //item in flashlight area
    

    void Start()
    {
        
    }

    public void TakeAction(){   //when action button is pressed
        if(currentHighlightedItem != null){
            currentHighlightedItem.ShowInfo();
        }
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.tag == "PickUp"){
            currentHighlightedItem = other.gameObject.GetComponent<ItemManager>();
            Debug.Log("item found");
        }
    }
    void OnTriggerExit2D(Collider2D other){
         if(other.gameObject.tag == "PickUp"){
            currentHighlightedItem = null;
            Debug.Log("item ignored");
        }
    }

}
