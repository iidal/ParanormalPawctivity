using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightController : MonoBehaviour
{
    Quaternion newRot = new Quaternion(0,0,0,0);
    float rot;
    public void UpdateFlashlightDirection(Vector2 direction){

        rot = Vector3.Angle(Vector3.up, direction);
        if(direction.x >0){
            rot = rot*-1;
        }
        newRot.eulerAngles = new Vector3(0,0,rot);
        transform.rotation = newRot;
    }
}
