using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{

    public TextMeshProUGUI HealthText;
    public int Health = 3;
    public int MaxHerat = 3;
    public int Gems;
    public GameObject o;
    public int HHH = 1;
    public static GameManager Instance;
    public TextMeshProUGUI GemText;
    // Start is called before the first frame update

    private void Awake()
    {
        if (FindObjectsOfType<GameManager>().Length > 1)
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        }

        else
        {
            DontDestroyOnLoad(this);
        }
    }
    void Start()
    {
        Instance = this;
        Gems = 0;
    }

    public void UnDO()
    {
        o.SetActive(false);
    }

    public void DOO()
    {
        o.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
      
        if(SceneManager.GetActiveScene().name == "Title")
        {

            Destroy(gameObject);
        }
        Debug.Log("HJ " + MaxHerat.ToString());
        MaxHerat = Mathf.Clamp(MaxHerat,0,10);
       
        if (Gems >= 20)
        {
            Gems = 0;
            MaxHerat += 1;
            Health += 1;
        }
        if (Health > MaxHerat)
        {
            Health = MaxHerat;
        }
        HealthText.text = "Health " + Health.ToString() + "/" + MaxHerat.ToString();
        GemText.text = "Gems:" + Gems;

    }

    public void AddGems(int num)
    {
        Gems += num;
        Debug.Log(num);
        Debug.Log(Gems);
    }

}
