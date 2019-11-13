using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerExploreScene : MonoBehaviour
{
    PlayerManager player;
    public CameraController cam;
    void Start()
    {
        player = GetComponentInChildren<PlayerManager>();

        player.LoadPlayer();
        cam.player = player.player;
    }


}
