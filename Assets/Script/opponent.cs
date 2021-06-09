using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class opponent : MonoBehaviour {

    public LevelManager LevelManager;

    private void Start()
    {
        LevelManager = FindObjectOfType<LevelManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            LevelManager.RespawnPlayer();
        }
    }
}
