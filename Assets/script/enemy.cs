using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemy : MonoBehaviour
{
    public int Respawn;
    public Transform player;
    public float moveSpeed = 2f;
    private Rigidbody2D rb;
    private Vector2 movement;
    [SerializeField] private float attackDamage = 10f;
    [SerializeField] private float attackSpeed = 1f;
    private float canAttack;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = player.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        rb.rotation = angle;
        direction.Normalize();
        movement = direction;
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.CompareTag("Player"))
        {
            SceneManager.LoadScene(Respawn);
        }
    }
    private void OnCollisionStay2D(Collision2D other) 
    {
        if (other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(Respawn);
        }
    }
    
        private void FixedUpdate() 
    {
        moveCharactor(movement);
    }
    void moveCharactor(Vector2 direction)
    {
        rb.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.deltaTime));
    }
}
