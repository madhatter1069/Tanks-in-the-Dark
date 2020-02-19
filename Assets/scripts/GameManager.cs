using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int numTeams;
    public int teamSize;
    private GameObject[] spawnRed = new GameObject[3];
    private GameObject[] spawnPur = new GameObject[3];
    private GameObject[] spawnGre = new GameObject[3];
    
    // Start is called before the first frame update
    void Start()
    {
        if (numTeams<2){numTeams = 2;}
        else if(numTeams>3){numTeams = 3;}
        if (teamSize<1){teamSize = 1;}
        else if(teamSize>3){teamSize = 3;}
        MakeTanks(spawnRed);
        MakeTanks(spawnPur);
        if (numTeams == 3){MakeTanks(spawnGre);}
    }

    // Update is called once per frame
    void Update()
    {
    }

    void MakeTanks(GameObject[] spawns){
        for (int i = 0; i < teamSize; i++)
        {
            spawns[i].GetComponent<TankSpawn>().Spawntank();
        }

    }
}
