using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour {

    int lives = 3;
    public Text livesText;
    public GameObject bullet;
    public float bulletSpeed = 1000;
    public Transform spawnPoint;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Debug.Log("Fire");
            GameObject nBullet = Instantiate(bullet, spawnPoint.position, spawnPoint.rotation);

            gameObject.GetComponent<AudioSource>().Play();

            if(gameObject.GetComponent<Transform>().position.x < spawnPoint.position.x)
            {
                nBullet.GetComponent<Rigidbody2D>().AddForce(Vector3.right * bulletSpeed);
            }
            else
            {
                nBullet.GetComponent<Rigidbody2D>().AddForce(Vector3.left * bulletSpeed);
            }
            Destroy(nBullet, 2f);
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
        if (collision.CompareTag("Coin"))
        {
            collision.gameObject.GetComponent<Coins>().Hide();
        }
    }
}
