using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProGen : MonoBehaviour
{
    public float RandX;
    public float RandY;
    public int seed;
    public int ObjectsToSpawn;
    public int GemsToSpawn;
    public GameObject[] Objects;
    public float Min;
    public float Max;


    private void Awake()
    {
        GemsToSpawn = Random.Range(0, 20);
        RandX = Random.Range(Min, Max);
        RandY = Random.Range(Min, Max);
        seed = Random.Range(0, 99999);
        Random.InitState(seed);
    } 
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < ObjectsToSpawn; i++)
        {
            RandX = Random.Range(Min, Max);
            RandY = Random.Range(Min, Max);
            var pos = new Vector2(RandX * Random.value , RandY * Random.value);
            GameObject spa = Instantiate(Objects[Random.Range(0, Objects.Length)], pos, Quaternion.identity) as GameObject;
        }

        for (int i = 0; i < GemsToSpawn; i++)
        {
            RandX = Random.Range(Min, Max);
            RandY = Random.Range(Min, Max);
            var pos = new Vector2(RandX * Random.value, RandY * Random.value);
            GameObject spa = Instantiate(Objects[0], pos, Quaternion.identity) as GameObject;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
