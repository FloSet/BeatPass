
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

    public void RespawnPlayer()
    {
        // Spieler zum Checkpoint
        player.gameObject.transform.position = currentCheckpoint.transform.position;
        player.Death();
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
