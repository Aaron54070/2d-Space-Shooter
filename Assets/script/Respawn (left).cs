using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawnleft : MonoBehaviour
{
    public GameObject enemy;
    float randX;
    Vector2 whereToSpawn;
    public float spawnRate = 2f;
    float nextSpawn = 0.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            randX = Random.Range (20.14f, 13.55f);
            whereToSpawn = new Vector2 (randX, transform.position.y);
            Instantiate (enemy, whereToSpawn, Quaternion.identity);
        }
    }
}
