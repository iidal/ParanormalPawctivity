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
    
    void Start()
    {

    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            Shoot();
        }

        // if (Input.touchCount > 0)
        // {

        //     Touch touch = Input.GetTouch(0);
        //     pointOnWorld = cam.ScreenToWorldPoint(touch.position);
        //     targetX = pointOnWorld.x;

        // if (targetX < barrierLeft.position.x)
        // {
        //     targetX = barrierLeft.position.x + 1;
        // }
        // else if (targetX > barrierRight.position.x)
        // {
        //     targetX = barrierRight.position.x - 1;
        // }

        //     transform.position = new Vector3(Mathf.Lerp(transform.position.x, targetX, 1* Time.deltaTime),transform.position.y, transform.position.z);





        // }
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

            transform.position = new Vector3(Mathf.Lerp(transform.position.x, targetX, 1 * Time.deltaTime), transform.position.y, transform.position.z);

        }
    }
    public void Shoot()
    {
        Instantiate(projectile, transform.position, Quaternion.identity);
    }


}
