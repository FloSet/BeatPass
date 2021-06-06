using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour {


    private LevelManager levelManager;
	// Use this for initialization
	void Start () {
        levelManager = FindObjectOfType<LevelManager>();
	}

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            levelManager.currentCheckpoint = gameObject;
            Debug.Log("Checkpoint erreicht");
        }
    }
}
