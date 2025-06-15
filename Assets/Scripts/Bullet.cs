using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Vector2 direction;
    public float speed = 10f;
    private Rigidbody2D _rb;
    private int bounceCount = 0;
    private int maxBounces = 2;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _rb.velocity = direction.normalized * speed;
    }

     public void SetDirection(Vector2 dir)
     {
        direction = dir.normalized;
        

     }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer == LayerMask.NameToLayer("Player"))
        
            return;
            bounceCount++;  
        
   
         if(bounceCount > maxBounces)
         {
            Destroy(gameObject);
         }
        else
        {
            direction = -direction;
            _rb.velocity = direction * speed;   

        }
    
    
    }




}
