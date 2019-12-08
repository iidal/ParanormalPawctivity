using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvaderGameManager : MonoBehaviour
{
    public static InvaderGameManager instance;
    [SerializeField]
    InvaderBlockManager blockManager;
    public bool gameEnded = false;

    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
        }

        Invoke("StartGame", 1f);
    }


    public void StartGame(){

        
        blockManager.StartCoroutine("SpawnBlocks");
    }

    public void GameOver(){
        gameEnded = true;
        Debug.Log("game over");
    }


}
