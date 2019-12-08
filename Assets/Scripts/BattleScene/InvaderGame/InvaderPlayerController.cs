using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvaderPlayerController : MonoBehaviour
{
    public Camera cam;


    //Moving
    Vector3 point; // touch point
    float targetX; // where to move player
    Vector3 pointOnWorld;

    [SerializeField]
    Transform barrierRight, barrierLeft; // barrier game obejcts on the sides
    
    //Shooting
    public GameObject projectile;
    public Transform bulletSpawn;
    
    void Start()
    {

    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            Shoot();
        }

        #if UNITY_STANDALONE_WIN || UNITY_EDITOR
        if (Input.GetMouseButton(0))
        {
            pointOnWorld = cam.ScreenToWorldPoint(Input.mousePosition);
            targetX = pointOnWorld.x;
            if (targetX < barrierLeft.position.x)
            {
                targetX = barrierLeft.position.x + 1;
            }
            else if (targetX > barrierRight.position.x)
            {
                targetX = barrierRight.position.x - 1;
            }
            float dist = Vector3.Distance(transform.position, new Vector3(targetX, transform.position.y, transform.position.z));
            transform.position = new Vector3(Mathf.Lerp(transform.position.x, targetX, 3 * Time.deltaTime), transform.position.y, transform.position.z);

        }
        #elif UNITY_ANDROID
        if (Input.touchCount > 0)
        {

            Touch touch = Input.GetTouch(0);
            pointOnWorld = cam.ScreenToWorldPoint(touch.position);
            targetX = pointOnWorld.x;

        if (targetX < barrierLeft.position.x)
        {
            targetX = barrierLeft.position.x + 1;
        }
        else if (targetX > barrierRight.position.x)
        {
            targetX = barrierRight.position.x - 1;
        }

            transform.position = new Vector3(Mathf.Lerp(transform.position.x, targetX, 1* Time.deltaTime),transform.position.y, transform.position.z);

        }

        
       

        #endif
    }
    public void Shoot()
    {
        Instantiate(projectile, bulletSpawn.position, Quaternion.identity);
    }

    public void OnDeath(){

        //"Destroy player"
        //cue the losing animations
        // show panels

    }


}
