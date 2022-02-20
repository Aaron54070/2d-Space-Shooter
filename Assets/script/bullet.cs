using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{

    public GameObject hitEffect;


     void OnCollisionEnter2D(Collision2D col) 
    {
        GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
        Destroy(effect, 1f);
        if (col.gameObject.tag.Equals ("Enemy"))
        {
            Destroy(col.gameObject);
            Destroy(gameObject);
        }
    }
}
