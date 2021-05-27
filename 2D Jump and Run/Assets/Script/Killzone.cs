using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Killzone : MonoBehaviour {

    public LevelManager LevelManager;

    private void Start()
    {
        LevelManager = FindObjectOfType<LevelManager>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            LevelManager.RespawnPlayer();
            Debug.Log("Spieler tot");
        }
        else
        {
            Debug.Log("Spieler lebt");
        }
    }
}
