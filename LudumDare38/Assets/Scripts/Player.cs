using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    public float Speed;
    public GameObject Par;
    public GameObject Par2;

    public float FallSpeed;
    public float JumpSpeed;
    Animator anim;
    public bool ShouldJu = true;
    public bool ShouldAdd = false; 
    bool DOO = false;
    public bool IsHit = false;
    float X;
    public Collider2D col;
    [Range(0f, 1f)]

    public float FCutJump;
    public Transform door;


  

 
    // Start is called before the first frame update
    void Awake()
    {
       
        anim = GetComponent<Animator>();
    }

    IEnumerator UNIN()
    {
        yield return new WaitForSeconds(1);
        IsHit = false;
    }

    // Update is called once per frame
    void Update()
    {
       
        Debug.Log(Mathf.Sign(X));
        Debug.LogWarning(Mathf.Abs(X) > Mathf.Epsilon);
        if (Mathf.Abs(X) > Mathf.Epsilon)
        {
            if (Input.GetAxisRaw("Horizontal") != 0f)
            {
                transform.localScale = new Vector2(Input.GetAxisRaw("Horizontal"), transform.localScale.y);
            }
        }
        anim.SetBool("IsRunning", Mathf.Abs(X) > Mathf.Epsilon);

        if(GameManager.Instance.Health < 1)
        {
            Destroy(gameObject);
        }
        if (Input.GetKeyDown(KeyCode.Space) && col.IsTouchingLayers(LayerMask.GetMask("Ground")) && ShouldJu)
        {

            AudioManager.Instance.PlaySound("Jump");
            rb.velocity = new Vector2(rb.velocity.x, JumpSpeed);
        }

        if(Input.GetKeyUp(KeyCode.Space) && rb.velocity.y > 0.1f)
        {
            rb.velocity = new Vector2(rb.velocity.x,rb.velocity.y * FCutJump);
        }
    }

    private void FixedUpdate()
    {
       
      




        //Movement
         X = Input.GetAxisRaw("Horizontal") * Speed;
   

       
        rb.velocity = new Vector2(X,rb.velocity.y);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Gem"))
        {
            GameManager.Instance.AddGems(1);
            AudioManager.Instance.PlaySound("Collect");
            Destroy(collision.gameObject);
        }
        if (collision.CompareTag("Heart"))
        {
            Heart har = collision.gameObject.GetComponent<Heart>();
            if(har.Who == 0)
            {
                GameManager.Instance.Health += 1;
                AudioManager.Instance.PlaySound("Heart");
                Destroy(collision.gameObject);
            }

            else if(har.Who == 1)
            {
                GameManager.Instance.MaxHerat += 1;
                AudioManager.Instance.PlaySound("Heart");
                Destroy(collision.gameObject);
            }

            else if (har.Who == 2)
            {
               
                AudioManager.Instance.PlaySound("Collect");
                Destroy(collision.gameObject);
                Destroy(door.gameObject);
            }

        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {

            GameManager.Instance.Health -= 1;
        
            if(GameManager.Instance.Health < 1)
            {
                AudioManager.Instance.PlaySound("BOOM");
                GameObject ob = Instantiate(Par2, transform.position, Quaternion.identity) as GameObject;
                Destroy(ob, 4);
            }

            else
            {
                GameObject ob = Instantiate(Par, transform.position, Quaternion.identity) as GameObject;
                Destroy(ob, 4);
                AudioManager.Instance.PlaySound("Hit");
            }
           
            IsHit = true;
            StartCoroutine(UNIN());
            //Scrapped.
            //anim.SetBool("IsHit", true);
            //rb.AddForce(-transform.right * 2000f);
            return;
        }
        

       
    }
}
