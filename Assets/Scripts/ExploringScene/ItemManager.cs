using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemManager : MonoBehaviour
{
    //items that can be picked up or give information

    public ItemObject itemInfo;
    bool pickUp; // false == info item, true == add to inventory (if wanted)
    string itemName;
    Sprite itemImage;
    string itemDescription;

    void Start()
    {
        LoadItemInfo();
    }

    public void ShowInfo(){
        UIManagerExploreScene.instance.ShowPanel(itemName, itemDescription, itemImage, pickUp);
    }
    void LoadItemInfo(){
        pickUp = itemInfo.pickUpable;
        itemName = itemInfo.itemName;
        itemDescription = itemInfo.itemDescription;
        itemImage = Resources.Load<Sprite>("Sprites/"+itemInfo.imageFileName);
    
    }
}
