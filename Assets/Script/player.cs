using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player : MonoBehaviour {

    int Score;
    public Text scoreText;

    private void Start()
    {
        Score = 0;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Coin")
        {
            Destroy(collision.gameObject);
            Debug.Log("Münze aufgesammelt");
            Score++;
            scoreText.text = "Score: " + Score.ToString();
            Debug.Log("Score: " + Score);
        }
    }
}
