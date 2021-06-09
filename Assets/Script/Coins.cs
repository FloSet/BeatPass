using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    public Transform checkpoint;
    public LevelManager levelManager;

    private void Start()
    {
        levelManager = FindObjectOfType<LevelManager>();    
    }

    public void Hide()
    {
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
        gameObject.GetComponent<Collider2D>().enabled = false;
        Debug.Log("Münze aufgesammelt");
        levelManager.CoinUp();
    }

    public void Show(Transform currentCheckpoint)
    {
        if(checkpoint == currentCheckpoint && !gameObject.GetComponent<SpriteRenderer>().enabled && !gameObject.GetComponent<Collider2D>().enabled)
        {
            gameObject.GetComponent<SpriteRenderer>().enabled = true;
            gameObject.GetComponent<Collider2D>().enabled = true;
            Debug.Log("Münze abgegeben");
            levelManager.CoinDown();
        }
    }
}
