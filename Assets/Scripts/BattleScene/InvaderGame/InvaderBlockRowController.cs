using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvaderBlockRowController : MonoBehaviour
{

    void Start()
    {
        StartCoroutine("MoveRow");
    }


    IEnumerator MoveRow()
    {

        while (InvaderGameManager.instance.gameEnded == false)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.2f, transform.position.z);
            yield return new WaitForSeconds(1f);
        }

    }

}
