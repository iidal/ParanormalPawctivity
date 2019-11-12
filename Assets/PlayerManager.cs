using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager instance;
    public GameObject playerPrefab;
    GameObject spawnPosition;
    public ItemManager currentItem;
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
    }
    public void ItemPickUp(){
        Debug.Log("item picked up");
        InventoryManager.instance.AddItemToInventory(currentItem.itemInfo);
        Destroy(currentItem.gameObject);
    }

    public void LoadPlayer(){
        spawnPosition = GameObject.Find("PlayerSpawnPosition");
        Instantiate(playerPrefab, spawnPosition.transform.position, Quaternion.identity);
    }
}
