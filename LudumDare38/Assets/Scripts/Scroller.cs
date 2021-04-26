using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroller : MonoBehaviour
{
    public float Speed;
    enum DigState { Deep, Ground, Stop, Check }
    [SerializeField] DigState state;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(FindObjectOfType<Player>() == null)
        {
            Destroy(GetComponent<Scroller>());
        }
    }
    private void FixedUpdate()
    {
        if (state == DigState.Ground)
        {
            transform.Translate(-transform.up * -Speed,Space.World);
        }

        else if(state == DigState.Deep)
        {
            transform.Translate(transform.up * Speed,Space.World);
        }

        else if(state == DigState.Check)
        {
            DoChecker();
        }
 
    }

    public void DoChecker()
    {
        throw new NotImplementedException();
    }
}
