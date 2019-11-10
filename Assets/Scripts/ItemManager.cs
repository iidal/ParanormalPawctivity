using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemManager : MonoBehaviour
{
    public ItemObject itemInfo;
    bool pickUp; // false == info item, true == add to inventory (if wanted)
    public string itemName;
    public Sprite itemImage;
    public string itemDescription;

    void Start()
    {
        LoadItemInfo();
    }


    void Update()
    {
        
    }
    public void ShowInfo(){
        UIManagerExploreScene.instance.ShowPanel(itemName, itemDescription, itemImage);
    }
    void LoadItemInfo(){
        Debug.Log("load info");
        pickUp = itemInfo.pickUpable;
        itemName = itemInfo.itemName;
        itemDescription = itemInfo.itemDescription;
        itemImage = Resources.Load<Sprite>("Sprites/"+itemInfo.imageFileName);
    }
}
