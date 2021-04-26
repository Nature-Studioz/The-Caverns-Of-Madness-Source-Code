using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flyer : MonoBehaviour
{
    public float Speed;
    float Numm;
    public Rigidbody2D rb;

    private void Awake()
    {
        Debug.Log(rb.velocity);
    }
    // Start is called before the first frame update
    void Start()
    {
        Numm = Speed;
    }

    // Update is called once per frame
    void Update()
    {
        
        if(GetComponent<Rigidbody2D>() == null)
        {
            gameObject.AddComponent<Rigidbody2D>();
            GetComponent<Rigidbody2D>().AddTorque(500f);
            Destroy(GetComponent<Flyer>());
        }
    }

    private void FixedUpdate()
    {
        if (GetComponent<PolygonCollider2D>() != null)
        {

          
            rb.velocity = transform.right * Speed;
        }

        else
        {

            Destroy(rb);


        }
       
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        Debug.Log("YECol");
        if(Speed > 0)
        {
            transform.localScale = new Vector2(-1f, transform.localScale.y);
            Speed = -Numm;
        }

        else if(Speed < 0)
        {
            transform.localScale = new Vector2(1f, transform.localScale.y);
            Speed = Numm;
        }
    }
}
