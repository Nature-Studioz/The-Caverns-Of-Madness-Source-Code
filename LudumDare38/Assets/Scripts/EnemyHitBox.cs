using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHitBox : MonoBehaviour
{
    public Collider2D col;
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (col.IsTouchingLayers(LayerMask.GetMask("Player")))
        {

            Rigidbody2D rb2 = GetComponent<Rigidbody2D>();
            rb2.AddTorque(500);


            
            AudioManager.Instance.PlaySound("Collect");
            collision.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(collision.gameObject.GetComponent<Rigidbody2D>().velocity.x, 7 / 2);
            GameManager.Instance.AddGems(1);

            Destroy(GetComponent<PolygonCollider2D>());
            Destroy(col);

        }
    }


}
