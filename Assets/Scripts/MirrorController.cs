using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorController : MonoBehaviour
{
    public PlayerController playerControllerScript;

    // Start is called before the first frame update
    void Awake()
    {
        Physics2D.IgnoreCollision(gameObject.GetComponent<Collider2D>(), playerControllerScript.GetComponent<Collider2D>(), true);

    }

    void Start()
    {
        transform.position = playerControllerScript.locations[3].transform.position;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void MirrorMove(int previousLocation)
    {
        transform.position = playerControllerScript.locations[previousLocation].transform.position;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("MThreat"))
        {
            playerControllerScript.deathSound.Play();
            playerControllerScript.isPlayerDead = true;
        }
    }
}
