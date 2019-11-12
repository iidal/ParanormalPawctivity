using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManagerExploreScene : MonoBehaviour
{
    public static UIManagerExploreScene instance;

    [Header("Infopanel for in game items")]
    public GameObject infoPanel;
    public TextMeshProUGUI infoItemName;
    public TextMeshProUGUI infoItemInfo;
    public Image infoItemSprite;
    public Button pickUpButton;
    
    
    private void Awake()
    {
        if (instance != null)
            Destroy(this);
        else
            instance = this;
    }

    public void ShowPanel(string name, string info, Sprite sprite, bool pickUp)
    {
        infoItemName.text = name;
        infoItemInfo.text = info;
        infoItemSprite.sprite = sprite;
        if (pickUp)
        {
            pickUpButton.interactable = true;
        }
        else
        {
            pickUpButton.interactable = false;
        }
        infoPanel.SetActive(true);

    }
}
