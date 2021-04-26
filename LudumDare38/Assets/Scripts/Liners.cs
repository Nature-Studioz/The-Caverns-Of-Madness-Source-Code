using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Liners : MonoBehaviour
{
    public GameObject Circle1;

    public GameObject Circle2;
    public LineRenderer line;
    public Material mat;
    
    // Start is called before the first frame update
    void Start()
    {
     
      
        line.positionCount = 2;
      
       
    }

    // Update is called once per frame
    void Update()
    {
      
            line.SetPosition(0, Circle1.transform.position);
            line.SetPosition(1, Circle2.transform.position);
        

        
    }
}
