using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager instance;
    public GameObject playerPrefab;
    public GameObject player;
    GameObject spawnPosition;

    [Header("Items the player interacts with in the game")]
    public ItemManager currentItem;
    public DoorController door;
    public InteractiveItem interactiveItem;
    void Start()
    {
        if (instance != null)
            Destroy(this);
        else
            instance = this;
    }

        public void TakeAction(){   //when action button is pressed
        

        if(currentItem!= null){
            currentItem.ShowInfo();
        }
        else if(interactiveItem != null){
            interactiveItem.CheckIfPlayerHasItem();
        }
        else if(door != null){
            door.CheckAndOpen();
        }
    }
    public void ItemPickUp(){
        Debug.Log("item picked up");
        InventoryManager.instance.AddItemToInventory(currentItem.itemInfo);
        Destroy(currentItem.gameObject);
    }

    public void LoadPlayer(){
        spawnPosition = GameObject.Find("PlayerSpawnPosition");
        player = Instantiate(playerPrefab, spawnPosition.transform.position, Quaternion.identity);
    }
}
