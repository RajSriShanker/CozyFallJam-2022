using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundController : MonoBehaviour
{
    //Ground Starting Position
    public Vector3 startPos;

    //Ground Move Speed
    public float moveSpeed = 1.0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Translate object down with move speed
        transform.Translate(0, moveSpeed * Time.deltaTime, 0);
        
        //If object is below -10 on the y axis
        if (transform.position.y > 10)
        {
            //Reset object to starting position
            transform.position = startPos;
        }
    }
}
