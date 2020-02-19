using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public GameObject P1;
    public GameObject P2;
    public GameObject playerOne;
    public GameObject playerTwo;
    // Start is called before the first frame update
    void Start()
    {
        playerOne = P1;
        playerTwo = P2;
    }

    // Update is called once per frame
    void Update()
    {
        if(!playerOne)
        {
            GameObject Player1 = Instantiate(playerOne, transform.position, transform.rotation); 
        }

    }
}
