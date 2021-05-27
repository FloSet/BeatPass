
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    //aktueller Checkpoint
    public GameObject currentCheckpoint;
    //Spieler
    public GameObject Player;


	public void RespawnPlayer()
    {
        // Spieler zum Checkpoint
        Player.transform.position = currentCheckpoint.transform.position;
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
