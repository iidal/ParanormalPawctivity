using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager instance;
    public List<ItemObject> pickedUpItems = new List<ItemObject>();

    public TextMeshProUGUI tempInventoryItem;

    void Start()
    {
        if (instance != null)
            Destroy(this);
        else
            instance = this;
    }

    public void AddItemToInventory(ItemObject item){

        pickedUpItems.Add(item);
        tempInventoryItem.text += " " + item.itemName;
    }
    public bool CheckForItem(string itemname){
        foreach(ItemObject io in pickedUpItems){
            if(io.itemName == itemname){
                return true;
            }
        }
        return false;
    }



}
