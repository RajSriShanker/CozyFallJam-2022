using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private MirrorController mirrorControllerScript;

    [SerializeField]
    private bool inColumn1 = false;
    [SerializeField]
    private bool inColumn2 = false;

    public Transform[] locations;

    
    public int currentLocation;
    public int previousLocation;

    public bool isPlayerDead = false;

    private void Awake()
    {
        Physics2D.IgnoreCollision(gameObject.GetComponent<Collider2D>(), mirrorControllerScript.GetComponent<Collider2D>(), true);
    }


    // Start is called before the first frame update
    void Start()
    {
        transform.position = locations[0].position;
        currentLocation = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
        //Reset Position
        if (Input.GetKeyDown(KeyCode.R))
        {
            transform.position = locations[0].position;
            previousLocation = 0;
        }

        //Column 1 Location
        if (Input.GetKeyDown(KeyCode.Space) && Input.GetKey(KeyCode.UpArrow) && inColumn1)
        {
            TempCheck();
            transform.position = locations[3].position;
            currentLocation = 3;
            mirrorControllerScript.MirrorMove(previousLocation);
        }

        else if (Input.GetKeyDown(KeyCode.Space) && Input.GetKey(KeyCode.DownArrow) && inColumn1)
        {
            TempCheck();
            transform.position = locations[5].position;
            currentLocation = 5;
            mirrorControllerScript.MirrorMove(previousLocation);
        }

        else if (Input.GetKeyDown(KeyCode.Space) && inColumn1)
        {
            TempCheck();
            transform.position = locations[4].position;
            currentLocation = 4;
            mirrorControllerScript.MirrorMove(previousLocation);
        }

        //Column 2 Location
        if (Input.GetKeyDown(KeyCode.Space) && Input.GetKey(KeyCode.UpArrow) && inColumn2)
        {
            TempCheck();
            transform.position = locations[0].position;
            currentLocation = 0;
            mirrorControllerScript.MirrorMove(previousLocation);
        }
        
        else if (Input.GetKeyDown(KeyCode.Space) && Input.GetKey(KeyCode.DownArrow) && inColumn2)
        {
            TempCheck();
            transform.position = locations[2].position;
            currentLocation = 2;
            mirrorControllerScript.MirrorMove(previousLocation);
        }
        
        else if (Input.GetKeyDown(KeyCode.Space) && inColumn2)
        {
            TempCheck();
            transform.position = locations[1].position;
            currentLocation = 1;
            mirrorControllerScript.MirrorMove(previousLocation);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Column1"))
        {
            inColumn2 = false;
            inColumn1 = true;
        }

        if (collision.gameObject.CompareTag("Column2"))
        {
            inColumn1 = false;
            inColumn2 = true;
        }

        if (collision.gameObject.CompareTag("Threat"))
        {
            isPlayerDead = true;
        }
    }

    public void TempCheck()
    {
        previousLocation = currentLocation;
    }
}
