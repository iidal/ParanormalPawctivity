using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager instance;
    public List<ItemObject> pickedUpItems = new List<ItemObject>();
    void Start()
    {
        if (instance != null)
            Destroy(this);
        else
            instance = this;
    }

    public void AddItemToInventory(ItemObject item){

        pickedUpItems.Add(item);
    }



}
