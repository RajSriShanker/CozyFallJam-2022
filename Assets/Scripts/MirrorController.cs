using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorController : MonoBehaviour
{
    public PlayerController playerControllerScript;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {        
        //If mirrorLocation is not current player location, store current player location in tempLocation, then set mirrorLocation to tempLocation when tempLocation does not equal current Player Location
    }

    public void MirrorMove(int previousLocation)
    {
        transform.position = playerControllerScript.locations[previousLocation].transform.position;
    }
}
