using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerExploreScene : MonoBehaviour
{
    PlayerManager player;
    GameObject levelObj;
    public CameraController cam;
    void Start()
    {
        player = GetComponentInChildren<PlayerManager>();
        levelObj = Resources.Load<GameObject>("Levels/Level-0");
        Instantiate(levelObj, Vector3.zero, Quaternion.identity);
        player.LoadPlayer();
        cam.player = player.player;
    }


}
