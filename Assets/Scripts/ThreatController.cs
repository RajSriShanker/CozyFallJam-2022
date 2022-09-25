using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThreatController : MonoBehaviour
{
    //Object move speed
    public float moveSpeed = 1.0f;

    //Starting Location
    public Transform startingLocation;

    //Target Location
    public Transform targetLocation;


    // Start is called before the first frame update
    void Start()
    {
        transform.position = startingLocation.position;
        Destroy(gameObject, 20);
    }

    // Update is called once per frame
    void Update()
    {
        //Translate from one Transfrom to another
        transform.position = Vector3.MoveTowards(transform.position, targetLocation.position, moveSpeed * Time.deltaTime);
    }

}
