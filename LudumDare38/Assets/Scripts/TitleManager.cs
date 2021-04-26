using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class TitleManager : MonoBehaviour
{
    public Animator anum;
    public string Scene = "Level1";
    public bool ShouldDo = false;
    bool IsDo = false;
    public GameObject ob;
    public AudioSource source;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(FindObjectOfType<Player>() == null && ShouldDo && !IsDo)
        {
            
                source.Stop();
            
            StartCoroutine(GameOver());
            IsDo = true;
        }
    }

    IEnumerator GameOver()
    {
        yield return new WaitForSeconds(3);
        ob.SetActive(true);
        StartCoroutine(FDAFS());
    }

    IEnumerator FDAFS()
    {
        yield return new WaitForSeconds(3);
        Scene = "Title";
        Play();
        
    }
    public void Play()
    {
       
        anum.SetBool("FadeAway", false);
        anum.gameObject.GetComponent<Image>().raycastTarget = true;

        StartCoroutine(Next());
    }

    

    public void PlatSOud()
    {
        AudioManager.Instance.PlaySound("Collect");
    }

    IEnumerator Next()
    {

        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(Scene);
    }
}
