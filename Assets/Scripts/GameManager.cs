using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private ScoreController scoreControllerScript;

    [SerializeField]
    private PlayerController playerControllerScript;

    [SerializeField]
    private MirrorController mirrorControllerScript;

    //UI Elements
    public Image winImage;
    public TextMeshProUGUI loseImage;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Restart();
        }

        if (playerControllerScript.isPlayerDead)
        {
            Death();
        }
    }

    public void Pause()
    {
        Time.timeScale = 0;
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        scoreControllerScript.scoreAmount = 0;
        Time.timeScale = 1;
        playerControllerScript.enabled = true;
        mirrorControllerScript.enabled = true;
    }

    public void Death()
    {
        playerControllerScript.enabled = false;
        mirrorControllerScript.enabled = false;
        Time.timeScale = 0;
        loseImage.gameObject.SetActive(true);
    }
}
