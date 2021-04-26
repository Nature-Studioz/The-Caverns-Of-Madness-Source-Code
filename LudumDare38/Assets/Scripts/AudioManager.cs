using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;
    public AudioClip[] clips;
    public GameObject ob;
    private void Awake()
    {
        Instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlaySound(string aud)
    {
        if (aud == "Jump")
        {
            GameObject obs = Instantiate(ob) as GameObject;
            obs.GetComponent<AudioSource>().clip = clips[0];
            obs.GetComponent<AudioSource>().Play();
            Destroy(obs, 5);

        }

        else if (aud == "Hit")
        {
            GameObject obs = Instantiate(ob) as GameObject;
            obs.GetComponent<AudioSource>().clip = clips[1];
            obs.GetComponent<AudioSource>().Play();
            Destroy(obs, 5);
        }

        else if (aud == "Collect")
        {
            GameObject obs = Instantiate(ob) as GameObject;
            obs.GetComponent<AudioSource>().clip = clips[2];
            obs.GetComponent<AudioSource>().Play();
            Destroy(obs, 5);
        }

        else if (aud == "Heart")
        {
            GameObject obs = Instantiate(ob) as GameObject;
            obs.GetComponent<AudioSource>().clip = clips[3];
            obs.GetComponent<AudioSource>().Play();
            Destroy(obs, 5);
        }


        else if (aud == "WEEEEE")
        {
            GameObject obs = Instantiate(ob) as GameObject;
            obs.GetComponent<AudioSource>().clip = clips[4];
            obs.GetComponent<AudioSource>().Play();
            Destroy(obs, 5);
        }

        else if (aud == "BOOM")
        {
            GameObject obs = Instantiate(ob) as GameObject;
            obs.GetComponent<AudioSource>().clip = clips[5];
            obs.GetComponent<AudioSource>().Play();
            Destroy(obs, 5);
        }

        else
        {
            Debug.LogWarning("No sound found, Haha that rhymes!!!");
        }
    }
}
