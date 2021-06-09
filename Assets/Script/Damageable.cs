using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damageable : MonoBehaviour
{
    public int health = 1;
    void ApplyDamage(int damage)
    {
        //Bei Leben gleich 0 --> unzerstörbar aber Kugel geht kaputt
        if (health != 0)
        {
            health -= damage;
            if (health <= 0)
            {
                //Objekt zerstören wenn kein Leben mehr
                Destroy(gameObject);
            }
        }
    }
}
