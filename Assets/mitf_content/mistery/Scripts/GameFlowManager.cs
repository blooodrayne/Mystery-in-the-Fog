using Fungus;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFlowManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Flowchart flowchart;
    void Start()
    {
        
    }
    private void GetBlockData()
    {
        var blockKey = PlayerPrefs.GetString("BlockKey");
    }
}
