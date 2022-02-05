using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MoneySystem : MonoBehaviour
{
    public Text Score;
    
    private static MoneySystem _instance;

    
    public int money;

    public float saveInterval;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Enter");
            Destroy(gameObject);
        }
    }
    private void Update()
    {
        Score.text = "SCORE:" + instance.money;
    }
    private static MoneySystem instance
    {
        get
        {
            
            if (_instance == null)
            {
                if (GameObject.Find("MoneySystem"))
                {
                    GameObject g = GameObject.Find("MoneySystem");
                    if (g.GetComponent<MoneySystem>())
                    {
                        _instance = g.GetComponent<MoneySystem>();
                    }
                    else
                    {
                        _instance = g.AddComponent<MoneySystem>();
                    }
                }
                else
                {
                    GameObject g = new GameObject();
                    g.name = "MoneySystem";
                    _instance = g.AddComponent<MoneySystem>();
                }
            }

            return _instance;
        }


        set
        {
            _instance = value;
        }
    }

    void Start()
    {
        //Make sure the Gameobject is named MoneySystem.
        gameObject.name = "MoneySystem";

        _instance = this;

        //load the saved money
        AddMoney(PlayerPrefs.GetInt("MoneySave", 0));

        //start the save interval.
        StartCoroutine("SaveMoney");
    }

    //while reality exists, save money every saveInterval.
    public IEnumerator SaveMoney()
    {
        while (true)
        {
            yield return new WaitForSeconds(saveInterval);
            PlayerPrefs.SetInt("MoneySave", instance.money);
        }
    }

    
    public static bool BuyItem(int cost)
    {
        if (instance.money - cost >= 0)
        {
            instance.money -= cost;
            return true;
        }
        else
        {
            return false;
        }
    }

    //Simply return the balance
    public static int GetMoney()
    {
        return instance.money;
    }

    //Add some money to the balance.
    public static void AddMoney(int amount)
    {
        instance.money += amount;
    }
}