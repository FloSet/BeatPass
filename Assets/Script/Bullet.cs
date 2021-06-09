using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int damage = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Wenn das gameObject vorhanden und das Skript "Damageable" besitzt
        if (collision.gameObject != null && collision.gameObject.GetComponent<Damageable>() != null)
        {
            //Schaden hinzufügen
            collision.SendMessage("applyDamage", damage, SendMessageOptions.DontRequireReceiver);
            //und Kugel zerstören
            Destroy(gameObject);
        }
    }
}
