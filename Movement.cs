
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public float moveSpeed;
    public float jumpHeight;
    // Use this for initialization
    void Start()
    {
        //Setting the movement speed
        moveSpeed = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        //Move on the x axis                                                     0 is the y axis          Move on the y axis
        transform.Translate(moveSpeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0.0f, moveSpeed * Input.GetAxis("Vertical") * Time.deltaTime);
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(GetComponent<Rigidbody>().velocity.x, jumpHeight, GetComponent<Rigidbody>().velocity.z);
        }
    }
}
