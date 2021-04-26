using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Rigidbody2D rb;
    public int RotMinus;
    float Num;
    public Transform shootPoint;
    public float WaitTime;
    public GameObject Bullet;
    float tim;

    // Start is called before the first frame update
    void Start()
    {
        Num = Mathf.Abs(transform.localScale.y);
    }

    // Update is called once per frame
    void Update()
    {
 
        if (Input.GetMouseButton(0) && Time.time > tim)
        {
            Shoot();
            tim = Time.time + WaitTime;
        }
    
        if(transform.right.x < 0)
        {
            transform.localScale = new Vector2(transform.localScale.x, -Num);
        }

        else if(transform.right.x > 0)
        {
            transform.localScale = new Vector2(transform.localScale.x, Num);
        }
    }

    private void Shoot()
    {
        GameObject ob = Instantiate(Bullet, shootPoint.position, transform.rotation) as GameObject;
        Destroy(ob,5);
    }

    private void FixedUpdate()
    {
        
     
            
        

    }
}
