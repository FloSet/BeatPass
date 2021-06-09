using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damageable : MonoBehaviour
{
    public int health = 1;
    void applyDamage(int damage)
    {
        if (health != 0)
        {
            health -= damage;
            if (health <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
