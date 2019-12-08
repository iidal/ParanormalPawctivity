using UnityEngine;
using System.Collections;

[CreateAssetMenu(fileName = "Item", menuName = "InGameObjects/InGameItem", order = 1)]
public class ItemObject : ScriptableObject {
    public bool pickUpable;
    public string itemName;
    public string imageFileName;
    public string itemDescription;



}
