using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightController : MonoBehaviour
{
    Quaternion newRot = new Quaternion(0,0,0,0);
    float rot;
    public void UpdateFlashlightDirection(float rot){
        newRot.eulerAngles = new Vector3(0,0,rot);
        transform.rotation = newRot;

        
    }
}
