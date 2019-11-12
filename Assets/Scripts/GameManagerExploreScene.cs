using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerExploreScene : MonoBehaviour
{
    PlayerManager player;
    void Start()
    {
        player = GetComponentInChildren<PlayerManager>();

        player.LoadPlayer();
    }


}
