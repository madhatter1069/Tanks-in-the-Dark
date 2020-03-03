using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public int numTeams;
    public int teamSize;
    public int r=0;
    public int p=0;
    public int g=0;
    [SerializeField] private GameObject[] spawnRed = new GameObject[3];
    [SerializeField] private GameObject[] spawnPur = new GameObject[3];
    [SerializeField] private GameObject[] spawnGre = new GameObject[3];
    public GameObject finish;
    
    // Start is called before the first frame update
    void Start()
    {
        if (numTeams<2){numTeams = 2;}
        else if(numTeams>3){numTeams = 3;}
        if (teamSize<1){teamSize = 1;}
        else if(teamSize>3){teamSize = 3;}
        MakeTanks(spawnRed);
        MakeTanks(spawnPur);
        r=p=teamSize;
        if (numTeams == 3){
            MakeTanks(spawnGre);
            g=teamSize;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (numTeams == 1){
            finish.SetActive(true);
            StartCoroutine(QuitGame());
        }
    }

    void MakeTanks(GameObject[] spawns){
        for (int i = 0; i < teamSize; i++)
        {
            spawns[i].GetComponent<TankSpawn>().Spawntank();
        }

    }
    private IEnumerator QuitGame(){
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene(0);
    }
}
