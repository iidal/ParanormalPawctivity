using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MiniPuzzleManager : MonoBehaviour
{

    [SerializeField]
    int collectAmount; //how many things need to be done/collected/whatever
    int collected = 0;

    public UnityEvent afterCompleted;
    void Start()
    {
        
    }

    public void Collecting(){
        collected++;
        if(collected == collectAmount){
            afterCompleted.Invoke();
        }
    }

}
