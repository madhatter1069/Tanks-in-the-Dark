using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    private GameObject teamCount;
    private GameObject numTanks;
    public int activeTanks;
    public int activeTeams;
    void Start(){
        activeTeams = activeTanks = 0;
        PlayerPrefs.SetInt("Tanks",activeTanks+1);
        PlayerPrefs.SetInt("Teams", activeTeams+2);
        object[] obj = GameObject.FindObjectsOfType<GameObject>();
        foreach (object o in obj)
        {
            GameObject f = (GameObject) o;
            if (f.name == "TeamCount"){
                teamCount = f;
            }
            if (f.name == "NumTanks"){
                numTanks = f;
            }
        }
    }
    public void PlayGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void AddTeams(){
        if(activeTeams < teamCount.transform.childCount-1){
            activeTeams++;
        }
        for (int i = 0; i < teamCount.transform.childCount; i++)
        {
            teamCount.transform.GetChild(i).gameObject.SetActive(false);
        }
        teamCount.transform.GetChild(activeTeams).gameObject.SetActive(true);
        PlayerPrefs.SetInt("Teams", activeTeams+2);
    }
    public void MinusTeams(){
        if(activeTeams > 0){
            activeTeams--;
        }
        for (int i = 0; i < teamCount.transform.childCount; i++)
        {
            teamCount.transform.GetChild(i).gameObject.SetActive(false);
        }
        teamCount.transform.GetChild(activeTeams).gameObject.SetActive(true);
        PlayerPrefs.SetInt("Teams", activeTeams+2);
    }
    public void AddTanks(){
        if (activeTanks < numTanks.transform.childCount-1){
            activeTanks++;
        }
        else{
            activeTanks = 2;
        }
        for (int i = 0; i < numTanks.transform.childCount; i++)
        {
            numTanks.transform.GetChild(i).gameObject.SetActive(false);
        }
        numTanks.transform.GetChild(activeTanks).gameObject.SetActive(true);
        PlayerPrefs.SetInt("Tanks",activeTanks+1);
    }
    public void MinusTanks(){
        if (activeTanks > 0){
            activeTanks--;
        }
        else{
            activeTanks = 0;
        }
        for (int i = 0; i < numTanks.transform.childCount; i++)
        {
            numTanks.transform.GetChild(i).gameObject.SetActive(false);
        }
        numTanks.transform.GetChild(activeTanks).gameObject.SetActive(true);
        PlayerPrefs.SetInt("Tanks",activeTanks+1);
    }

}
