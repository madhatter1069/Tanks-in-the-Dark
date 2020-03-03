using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum team {red, purple, green};

public class TargetDetection : MonoBehaviour
{
    public team teamColor;
    public GameObject g;

    // Start is called before the first frame update
    void Start()
    {
            object[] obj = GameObject.FindObjectsOfType<GameObject>();
            foreach (object o in obj)
            {
                g = (GameObject) o;
                if (g.name == "GameManager"){
                    break;
                }
            }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D coll)
    { 
        if(coll.CompareTag("Wall"))
        {
            Destroy(gameObject);
        }
        
        else if (coll.CompareTag("Player") && coll.gameObject.GetComponent<TankMovement>().teamColor != teamColor){ 
            if (coll.gameObject.GetComponent<TankMovement>().teamColor == team.red)
            {
                g.GetComponent<GameManager>().r--;
                if (g.GetComponent<GameManager>().r==0){g.GetComponent<GameManager>().numTeams--;}
            }
            else if (coll.gameObject.GetComponent<TankMovement>().teamColor == team.purple)
            {
                g.GetComponent<GameManager>().p--;
                if (g.GetComponent<GameManager>().p==0){g.GetComponent<GameManager>().numTeams--;}
            }
            else if (coll.gameObject.GetComponent<TankMovement>().teamColor == team.green)
            {
               g.GetComponent<GameManager>().g--;
               if (g.GetComponent<GameManager>().g==0){g.GetComponent<GameManager>().numTeams--;}
            }
            Destroy(gameObject);
            Destroy(coll.gameObject);
        }
    }


}
