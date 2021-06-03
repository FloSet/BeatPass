using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour {

    int Score;
    int lives = 3;
    public Text scoreText;
    public Text livesText;

    private void Start()
    {
        Score = 0;
    }

    public void Death()
    {
        lives--;

        if (lives < 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        else
        {
            livesText.text = "Leben: " + lives.ToString();
        }
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
