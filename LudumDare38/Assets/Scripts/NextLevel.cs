using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class NextLevel : MonoBehaviour
{
    public string scene;
    public Animator anim;
    public bool ShouldNext = false;
    public bool End = false;

    // Start is called before the first frame update
    void Awake()
    {
       
      
        anim = FindObjectOfType<HHas>().GetComponent<Animator>();
        anim.SetBool("FadeAway", true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<Player>().ShouldJu = false;
            anim.SetBool("FadeAway", false);
            AudioManager.Instance.PlaySound("WEEEEE");
            StartCoroutine(DO ());
        }
    }

    IEnumerator DO()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene(scene);
    }
}
