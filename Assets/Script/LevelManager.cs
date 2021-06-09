
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour {

    //aktueller Checkpoint
    public GameObject currentCheckpoint;
    //Spieler
    public Player player;
    //Initialisierung der Punkte
    private int coins = 0;

    public Text scoreText;

    private void Start()
    {
        player = FindObjectOfType<Player>();
    }

    public void CoinUp()
    {
        coins += 1;
        scoreText.text = "Münzen: " + coins.ToString();
    }

    public void CoinDown()
    {
        coins -= 1;
        scoreText.text = "Münzen: " + coins.ToString();
    }

    public void RespawnPlayer()
    {
        // Spieler zum Checkpoint
        player.gameObject.transform.position = currentCheckpoint.transform.position;
        player.Death();


        foreach(Coins coins in FindObjectsOfType<Coins>())
        {
            coins.Show(currentCheckpoint.transform);
        }
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
