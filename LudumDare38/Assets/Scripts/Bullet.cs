using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float Speed;
    public LayerMask targetMask;
    public LayerMask avoiderMask;
    public Rigidbody2D rb;
    public float Damage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        rb.velocity = transform.up * Speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
       
        Destroy(gameObject);

      
    }
}
