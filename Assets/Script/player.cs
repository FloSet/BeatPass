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
    public GameObject bullet;
    public float laserSpeed;
    public Transform spawnPoint;

    private void Start()
    {
        Score = 0;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Debug.Log("Fire");
            GameObject nBullet = Instantiate(bullet, spawnPoint.position, spawnPoint.rotation);
            nBullet.GetComponent<Rigidbody2D>().AddForce(Vector3.right * laserSpeed);
        }
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
