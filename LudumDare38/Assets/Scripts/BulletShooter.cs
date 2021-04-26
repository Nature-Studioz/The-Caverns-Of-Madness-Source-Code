using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletShooter : MonoBehaviour
{
    public GameObject ob;
    public float WaitTime;
    public Transform bulletPoint;
    float wa;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > wa)
        {
            GameObject obs = Instantiate(ob, bulletPoint.position, transform.rotation);
            Destroy(obs, 5);
            wa = Time.time + WaitTime;
            
        }
    }
}
