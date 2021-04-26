using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart : MonoBehaviour
{
    public int Add;
    public float Speed;
    public float Amp;
    float numm;
    public int Who;

    
    enum WhatAmI { RegHeart,CapHeart,Key}
    [SerializeField] WhatAmI what;
    // Start is called before the first frame update
    void Start()
    {
        if(what == WhatAmI.CapHeart)
        {
            Who = 1;
        }

        else if (what == WhatAmI.Key)
        {
            Who = 2;
        }

        else if (what == WhatAmI.RegHeart)
        {
            Who = 0;
        }
        numm = Speed;
  
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

    private void FixedUpdate()
    {
        transform.Translate( new Vector2(0f, Amp * Mathf.Sin(Time.time * Speed * Mathf.PI)),Space.World);
    }




}
