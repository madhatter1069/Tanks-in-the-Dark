using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firing : MonoBehaviour
{
    public GameObject x;
    public float bulletStartDist;
    public float bulletSpeed;
    public string fire;
    public float timer;
    private float shootTime = .1f;
    // Start is called before the first frame update
    void Start()
    {
        timer = shootTime;
    }

    // Update is called once per frame
    void Update()
    {
        timer+=Time.deltaTime;
        if (Input.GetKeyDown(fire)) //GetKeyDown to limit to one bullet per input
        {
            if (timer>= shootTime){
                GameObject bullet = Instantiate(x, 
                                            transform.position + bulletStartDist * transform.forward, 
                                            transform.rotation);
                bullet.GetComponent<TargetDetection>().teamColor = gameObject.GetComponent<TankMovement>().teamColor;
                bullet.GetComponent<Rigidbody2D>().velocity = gameObject.GetComponent<TankMovement>().GetFiringAim() * bulletSpeed * Time.deltaTime; //Fire bullet
                timer = 0;
            }
        }
    }


}
