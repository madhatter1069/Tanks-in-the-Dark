using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMovement : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed = 300.0f;
    private Rigidbody2D rd;
    private Vector2 firingAim;
    public string up;
    public string left;
    public string right;
    public string down;
    public team teamColor;

    void Start()
    {
        rd = gameObject.GetComponent<Rigidbody2D>();
        firingAim = Vector2.up;
    }

    // Update is called once per frame
    void Update()
    {
        rd.velocity = Vector3.zero; //reset velocity

        if (Input.GetKey(right)) //Find Button and then adjust accordingly
        {
            transform.eulerAngles = Vector3.forward * -90;
            rd.velocity = Vector2.right * Time.deltaTime * speed;
            firingAim = Vector2.right; //Change tank facing
        }
        else if (Input.GetKey(left))
        {
            transform.eulerAngles = Vector3.forward * 90;
            rd.velocity = Vector2.left * Time.deltaTime * speed;
            firingAim = Vector2.left;
        }
       else if (Input.GetKey(up))
        {
            transform.eulerAngles = Vector3.forward * 0;
            rd.velocity = Vector2.up * Time.deltaTime * speed;
            firingAim = Vector2.up;
        }
        else if (Input.GetKey(down))
        {
            transform.eulerAngles = Vector3.forward * 180;
            rd.velocity = Vector2.down * Time.deltaTime * speed;
            firingAim = Vector2.down;
        }
   }

    public Vector2 GetFiringAim()
    {
        return firingAim;
    }
}

