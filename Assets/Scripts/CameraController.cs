using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public static CameraController instance;

    public GameObject player;
    float min_X = -8f;
    float max_X = 8f;
    float min_Y = -8f;
    float max_Y = 8f;

    void Start()
    {
          if (instance != null)
            Destroy(this);
        else
            instance = this;
    }

 
    void Update()
    {
       //transform.position = new Vector3(player.transform.position.x, player.transform.position.y, transform.position.z );

        // transform.position = new Vector3(
        //     Mathf.Clamp(transform.position.x, min_X, max_X),
        //     Mathf.Clamp(transform.position.y, min_Y, max_Y),
        //     transform.position.z
        // );

    }
    public void UpdatePosition(Vector3 pos){
        transform.position = new Vector3(pos.x, pos.y, transform.position.z);
    }
}
