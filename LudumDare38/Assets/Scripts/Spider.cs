using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spider : MonoBehaviour
{


    public float Speed;
    public float Amp;
 



    
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
        transform.Translate(new Vector2(0f, Amp * Mathf.Sin(Time.time * Speed * Mathf.PI)), Space.World);
    }

}
