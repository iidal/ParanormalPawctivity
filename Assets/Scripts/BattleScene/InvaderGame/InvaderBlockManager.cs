using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


public class InvaderBlockManager : MonoBehaviour
{
    public static InvaderBlockManager instance;

    [SerializeField]
    List<GameObject> blockRows = new List<GameObject>();
    List<InvaderBlockRowController> rowControllers = new List<InvaderBlockRowController>();

    [SerializeField]
    string invaderTypeName;     //later get this from previous scene

    int totalBlocks = 0; // how many blocks are in formation
    int blocksDestroyed = 0; // how many blocks have been destroyed
    void Start()
    {
        if(instance != null){
            Destroy(this);
        }
        else{
            instance = this;
        }

        LoadRows();

        Debug.Log("total: "+totalBlocks);
    }

    public void BlockDestroyed(){
        blocksDestroyed++;
        if(blocksDestroyed >= totalBlocks){
            Debug.Log("game won");
        }
    }
    public IEnumerator SpawnBlocks()
    {
        for (int i = 0; i < blockRows.Count; i++)
        {
            Instantiate(blockRows[i], transform.position, Quaternion.identity);
            yield return new WaitForSeconds(3f);
        }
    }
    void LoadRows()
    {
        GameObject[] rows = Resources.LoadAll("Minigames/Invader/BlockRows/" + invaderTypeName).Cast<GameObject>().ToArray();

        GameObject temp;

        foreach (GameObject ob in rows)
        {
            temp = (GameObject)ob;
            blockRows.Add(temp);
            rowControllers.Add(temp.GetComponent<InvaderBlockRowController>());
        }
        foreach(InvaderBlockRowController ibc in rowControllers){
            totalBlocks += ibc.transform.childCount;
        }

    }
}
