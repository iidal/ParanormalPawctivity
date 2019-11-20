using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InteractiveItem : MonoBehaviour
{

    

    [SerializeField]
    string neededItem;
    public UnityEvent IfHasItem;

    void Start()
    {
        
    }

    public void CheckIfPlayerHasItem(){
       bool hasItem = InventoryManager.instance.CheckForItem(neededItem);
       if(hasItem){
           DoAction();
       }
       else{
           //hey bitch cant do shit
       }
    }

    void DoAction(){
        IfHasItem.Invoke();
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.tag =="PlayerFlashlight"){
            PlayerManager.instance.interactiveItem = this;
        }
    }
    void OnTriggerExit2D(Collider2D other){
        if(other.tag =="PlayerFlashlight"){
            PlayerManager.instance.interactiveItem = null;
        }
    }
}
