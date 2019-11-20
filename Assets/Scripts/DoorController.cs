using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    [SerializeField]
    Transform nextPosition;
    [SerializeField]
    Transform nextCameraPosition;

    [SerializeField]
    string keyObject;   //what item is needed to open the door
    void Start()
    {
        
    }

    public void CheckAndOpen(){
       bool temp = InventoryManager.instance.CheckForItem(keyObject);
       if(temp){
           Debug.Log("open door");
           UseDoor();
       }
    }
    void UseDoor(){
        PlayerManager.instance.player.transform.position = nextPosition.position;
        CameraController.instance.UpdatePosition(nextCameraPosition.position);
    }


    

    void OnTriggerEnter2D(Collider2D other){
        if(other.tag =="PlayerFlashlight"){
            Debug.Log("door found");
            PlayerManager.instance.door = this;
        }
    }
    void OnTriggerExit2D(Collider2D other){
        if(other.tag =="PlayerFlashlight"){
            Debug.Log("door ignored");
            PlayerManager.instance.door = null;
        }
    }
    


}
