using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    [SerializeField]
    private PlayerController playerControllerScript;

    public TextMeshProUGUI scoreText;
    public float scoreAmount;
    public int scoreMultiplier;

    // Start is called before the first frame update
    void Start()
    {
        scoreAmount = 0;
        scoreMultiplier = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
        scoreText.text = "" + (int)scoreAmount;
        if (playerControllerScript.isPlayerDead == false)
        {
            scoreAmount += Time.deltaTime * scoreMultiplier;
        }
    }
}
