using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    public Transform checkpoint;
    private LevelManager levelManager;

    private void Start()
    {
        levelManager = FindObjectOfType<LevelManager>();    
    }

    public void Hide()
    {
        //Renderer und Collider deaktivieren
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
        gameObject.GetComponent<Collider2D>().enabled = false;
        Debug.Log("M�nze aufgesammelt");
        //M�nze dazuzu�hlen
        levelManager.CoinUp();
    }

    public void Show(Transform currentCheckpoint)
    {
        //Pr�fen zu welchem CheckPoint die M�nze geh�rt, und ob die Komponnenten aktiviert sind, damit nicht noch aktivierte M�nzen den Punktestand manipulieren
        if(checkpoint == currentCheckpoint && !gameObject.GetComponent<SpriteRenderer>().enabled && !gameObject.GetComponent<Collider2D>().enabled)
        {
            //Renderer und Collider aktivieren
            gameObject.GetComponent<SpriteRenderer>().enabled = true;
            gameObject.GetComponent<Collider2D>().enabled = true;
            Debug.Log("M�nze abgegeben");
            //M�nze abziehen
            levelManager.CoinDown();
        }
    }
}
