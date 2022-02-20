using UnityEngine;
using System.Cillection;

public public class PlayerControl : MonoBehaviour
{
    public float speed;

    void Start() 
    {
        
    }
    void Update()
    {
        float x = Input.GetAxisRaw ("Horizontal");
        float y = Input.GetAxisRaw ("Vertical");

        Vector2 direction = new vector2 (x,y).normalized;

        Move (direction);
    }
    void Move(Vector2 direction)
    {
        Vector2 min = Camera.main.ViewportToWorldPoint (new Vector2 (0,0));
        Vector2 min = Camera.main.ViewportToWorldPoint (new Vector2 (1,1));

        max.x = max.x - 0.225f;
        min.x = min.x + 0.225f;

        max.y = max.y - 0.285f;
        min.y = min.y + 0.285f;

        Vector2 pos = transform.position;
        
        pos += direction * speed * time.deltaTime;

        pos.x = Mathf.Clamp (pos.x, min.x, max.x);
        pos.y = Mathf.Clamp (pos.y, min.y, max.y);
        
        transform.position = pos;
        }
}