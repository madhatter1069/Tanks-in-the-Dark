using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawn : MonoBehaviour
{
    public GameObject tank;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Spawntank()
    {
        Instantiate(tank, 
                    new Vector3(transform.position.x, transform.position.y, 0),
                    transform.rotation);
    }
}
