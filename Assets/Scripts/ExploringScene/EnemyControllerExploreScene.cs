using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyControllerExploreScene : MonoBehaviour
{
    public UnityEvent EnemyEncounter;


    void Start()
    {

    }


    public void EncounterEnemy(){
        EnemyEncounter.Invoke();

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "PlayerFlashlight")
        {
            PlayerManager.instance.enemy = this;
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "PlayerFlashlight")
        {
            PlayerManager.instance.enemy = null;
        }
    }
}
