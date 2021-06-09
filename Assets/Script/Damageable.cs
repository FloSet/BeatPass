using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damageable : MonoBehaviour
{
    public int health = 1;
    void ApplyDamage(int damage)
    {
        //Bei Leben gleich 0 --> unzerst�rbar aber Kugel geht kaputt
        if (health != 0)
        {
            health -= damage;
            if (health <= 0)
            {
                //Objekt zerst�ren wenn kein Leben mehr
                Destroy(gameObject);
            }
        }
    }
}
