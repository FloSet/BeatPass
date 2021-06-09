using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int damage = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject != null && collision.gameObject.GetComponent<Damageable>() != null)
        {
            collision.SendMessage("applyDamage", damage, SendMessageOptions.DontRequireReceiver);
            Destroy(gameObject);
        }
    }
}
