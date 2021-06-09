using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Killzone : MonoBehaviour {

    private LevelManager LevelManager;

    private void Start()
    {
        //LevelManager automatisiert dem LevelManager-Objekt zuweisen
        LevelManager = FindObjectOfType<LevelManager>();
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        //Wenn Spieler mit Gegner in Berührung kommt --> Neu Spawnen
        if (collision.CompareTag("Player"))
        {
            LevelManager.RespawnPlayer();
        }
    }
}
