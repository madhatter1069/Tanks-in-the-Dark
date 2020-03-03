using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum team {red, purple, green};

public class TargetDetection : MonoBehaviour
{
    public team teamColor;

    // Start is called before the first frame update
    void Start()
    {
        
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
            //coll.gameObject.transform.position = new Vector3(0, 0, 0);
            Destroy(gameObject);
            Destroy(coll.gameObject);
        }
    }


}
